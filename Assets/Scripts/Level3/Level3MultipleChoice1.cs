using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3MultipleChoice1 : MonoBehaviour {

	List<string> questions = new List<string>() {" "};
	List<string> correctAnswer = new List<string>() {" "};


//	public Text textquest;
	public List<string> ChosenAnswer;
	public RectTransform resultsObj;																																																																										

//	public enum TheAnswer{
//		Choice1,
//		Choice2,
//		Choice3,
//		Choice4
//	}

	public GameObject btn;

	public GameObject Disable1;
	public GameObject Disable2;
	public GameObject Disable3;
	public GameObject Disable4;

	public GameObject CallLevel3MultipleChoice1;
	public GameObject btnHint;
	public GameObject HintText;


	public static string selectedAnswer;																																																																									

	public static string choiceSelected="n";

	public static int randQuestion = -1;

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
		if (randQuestion == -1) {
			randQuestion = Random.Range (0, 1);
		}

		if  (randQuestion > -1) {
//			GetComponent<Text> ().text = questions [randQuestion];
		}
			//Debug.Log (questions [randQuestion]);
			if (choiceSelected == "y") {

				choiceSelected = "n"; 
			if (correctAnswer[randQuestion] == selectedAnswer) {

					resultsObj.GetComponent<Text> ().text = "Correct, click Done to continue";
					btn.SetActive (true);
					Disable1.SetActive (false);
					Disable2.SetActive (false);
					Disable3.SetActive (false);
					Disable4.SetActive (false);
					btnHint.SetActive (false);
					HintText.SetActive (false);

				}
			if (correctAnswer[randQuestion] != selectedAnswer) {

					resultsObj.GetComponent<Text> ().text = "Wrong Answer! Try again!";
					btnHint.SetActive (true);
					GameObject.Find ("HealthBars").GetComponent<HealthManager> ().healthcounter++;
	//				StartCoroutine(Wait());

				}
			}
		}

	public void Hinter(){
		HintText.SetActive (true);
		Debug.Log ("clicked");
	}

	public void Done(){
		GameObject.Find ("HealthBars").GetComponent<HealthManager> ().trackcount--;
		BgmHandler.main.ResumeMain(1.4f);
		GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().victor = 0;
		GameObject.Find ("Jamieson").GetComponent<InteractTrainer> ().defeated = true;
		GameObject.Find ("Jamieson").GetComponent<InteractTrainer> ().busy = false;
		/* StartCoroutine(BacktoWorld()); */
		CallLevel3MultipleChoice1.SetActive (false);
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