using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level4MiniMulti1 : MonoBehaviour {

	List<string> questions = new List<string>() {" "};
	List<string> correctAnswer = new List<string>() {" "};


	//	public Text textquest;
	public List<string> ChosenAnswer;
	public RectTransform resultsObj;																																																																										
	public GameObject btn;
	public int monitor;

	//	public enum TheAnswer{
	//		Choice1,
	//		Choice2,
	//		Choice3,
	//		Choice4
	//	}
	public GameObject Disable1;
	public GameObject Disable2;
	public GameObject Disable3;
	public GameObject Disable4;
	public GameObject Disable5;

	public static string selectedAnswer;																																																																									

	public static string choiceSelected="n";

	public static int randQuestion = -1;

	public GameObject CallLevel4MiniMulti1;
	public GameObject btnHint;
	public GameObject HintText;

	// Use this for initialization
	void Start () {
		
		DontDestroyOnLoad (resultsObj);
		DontDestroyOnLoad (btn);
		DontDestroyOnLoad (btnHint);
		DontDestroyOnLoad (HintText);
		correctAnswer = ChosenAnswer;
	}

	// Update is called once per frame
	void Update () {
		/* GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().defeated = false; */
		if (randQuestion == -1) {
			randQuestion = Random.Range (0, 1);
		}

		if  (randQuestion > -1) {
			//			GetComponent<Text> ().text = questions [randQuestion];
		}
		if (monitor == 1) {

		//	Debug.Log("i worked");
			resultsObj.GetComponent<Text> ().text = "You failed to guess correctly LOL!";
			btn.SetActive (true);
			Disable1.SetActive (false);
			Disable2.SetActive (false);
			Disable3.SetActive (false);
			Disable4.SetActive (false);
			Disable5.SetActive (false);
			btnHint.SetActive (false);
			HintText.SetActive (false);
			//GameObject.Find ("HealthBars").GetComponent<HealthManager> ().healthcounter++;
		}
		//Debug.Log (questions [randQuestion]);
		if (choiceSelected == "y") {

			choiceSelected = "n"; 
			if (correctAnswer[randQuestion] == selectedAnswer) {

				resultsObj.GetComponent<Text> ().text = "Wow you did it, good job!";
				btn.SetActive (true);
				Disable1.SetActive (false);
				Disable2.SetActive (false);
				Disable3.SetActive (false);
				Disable4.SetActive (false);
				Disable5.SetActive (false);
				btnHint.SetActive (false);
				HintText.SetActive (false);

			}
			if (correctAnswer[randQuestion] != selectedAnswer) {

				resultsObj.GetComponent<Text> ().text = "Uh-oh, last guess left!";
				btnHint.SetActive (true);
				GameObject.Find ("Guess").GetComponent<Level4GuessTracker1> ().guesscount--;
				//				StartCoroutine(Wait());

			}
	
		}
	}

	public void Hinter(){
		HintText.SetActive (true);
		Debug.Log ("clicked");
	}


	public void MiniDone(){

		//	GameObject.Find ("HealthBars").GetComponent<HealthManager> ().trackcount--;
		BgmHandler.main.ResumeMain(1.4f);
		GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().victor = 0;
		GameObject.Find ("Michael").GetComponent<InteractTrainer> ().defeated = true;
		GameObject.Find ("Michael").GetComponent<InteractTrainer> ().busy = false;
		/* StartCoroutine(BacktoWorld()); */
		CallLevel4MiniMulti1.SetActive (false);
		//	StartCoroutine(ScreenFade.main.Fade(true, 2f));
		Scene.main.Battle.gameObject.SetActive(false);
	}

	/* 	IEnumerator BacktoWorld(){
		yield return new WaitForSeconds(0.4f);
		CallMultipleChoice.SetActive (false);
		StartCoroutine(ScreenFade.main.Fade(true, 2f));
		Scene.main.Battle.gameObject.SetActive(false);
	} */

	//	IEnumerator Wait(){
	//		yield return new WaitForSeconds(0.4f);
	//	}
}