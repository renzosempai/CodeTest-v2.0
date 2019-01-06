using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuizHolder : MonoBehaviour {

	public GameObject CallTextQuiz;

	//	private string answer;
	private int counter;

	private int countGuess;
	public GameObject wrong;

	[SerializeField]
	public GameObject btnDone;

//	[SerializeField]
	public InputField input;

	[SerializeField]
	public Transform text;

	[SerializeField]
	public Text thistext;

	public GameObject btnHint;
	public GameObject HintText;

//	public string Question;


	public string Answer;
	private string sagot;

	public void Start()
	{
		//Adds a listener that invokes the "LockInput" method when the player finishes editing the main input field.
		//Passes the main input field into the method when "LockInput" is invoked
		input.onEndEdit.AddListener(delegate {LockInput(input); });

		//Stated at start so it won't be destroyed after changing scenes
		DontDestroyOnLoad (wrong);
		DontDestroyOnLoad (btnDone);
		DontDestroyOnLoad (input);
		DontDestroyOnLoad (text);
		DontDestroyOnLoad (thistext);
		DontDestroyOnLoad (btnHint);
		DontDestroyOnLoad (HintText);
	}

	void LockInput(InputField input)
	{
		if (input.text.Length > 0)
		{
			Debug.Log("Input has been entered");
		}
		else if (input.text.Length == 0)
		{
			Debug.Log("Submitted empty");
		}
	}

	void Awake(){
		sagot = Answer.ToLower();
//		text.GetComponent<Text> ().text = Question;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().defeated = false;
			
	}

	public void GetInput(string guess){
		CompareGuesses (guess);
//		input.text = "";
//		countGuess++;
	}

	void CompareGuesses(string guess){
		if (guess.ToLower() == sagot) {

			thistext.text = "Correct Answer: " + guess + ", Please click Done to continue";
			wrong.SetActive (false);
			btnDone.SetActive (true);
			btnHint.SetActive (false);
			HintText.SetActive (false);
			Debug.Log ("Correct");
			//			counter++;

		} else if (guess != sagot){
			wrong.SetActive (true);
			btnHint.SetActive (true);
			Debug.Log ("wrong");
			GameObject.Find ("HealthBars").GetComponent<HealthManager> ().healthcounter++;
		}

	}
	public void Hinter(){
		HintText.SetActive (true);
	}

	public void Done(){
		GameObject.Find ("HealthBars").GetComponent<HealthManager> ().trackcount--;
		BgmHandler.main.ResumeMain(1.4f);
		GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().victor = 0;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().defeated = true;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().busy = false;
		StartCoroutine(BacktoWorld());
	}

	IEnumerator BacktoWorld(){
		yield return new WaitForSeconds(0.4f);
		CallTextQuiz.SetActive (false);
		StartCoroutine(ScreenFade.main.Fade(true, 2f));
		Scene.main.Battle.gameObject.SetActive(false);
	}
}
