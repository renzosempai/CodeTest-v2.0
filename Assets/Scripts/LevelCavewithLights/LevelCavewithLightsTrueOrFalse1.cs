using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCavewithLightsTrueOrFalse1 : MonoBehaviour {

	List<string> questions = new List<string> () {" "};
	List<string> correctAnswer = new List<string>() {" "};
	public GameObject CallLevelCavewithLightsTrueOrFalse1;

	public List<string> TheAnswer;

	public GameObject Disable1;
	public GameObject Disable2;

	public Transform resultObj;

	public static string selectedAnswer;

	public static string choiceSelected="n";

	public static int randQuestion = -1;

	public GameObject btn2;

	public GameObject btnHint;
	public GameObject HintText;
	// Use this for initialization
	void Start () {
		
		DontDestroyOnLoad (btnHint);
		DontDestroyOnLoad (HintText);
		correctAnswer = TheAnswer;
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
		//Debug.Log (questions [randQuestion]);
		if (choiceSelected == "y") {

			choiceSelected = "n"; 
			if (correctAnswer [randQuestion] == selectedAnswer) {

				resultObj.GetComponent<Text> ().text = "Correct, click Done to continue";

				btn2.SetActive (true);
				Disable1.SetActive (false);
				Disable2.SetActive (false);
				btnHint.SetActive (false);
				HintText.SetActive (false);
			}
			if (correctAnswer [randQuestion] != selectedAnswer) {

				resultObj.GetComponent<Text> ().text = "Wrong Answer";
				btnHint.SetActive (true);
				GameObject.Find ("HealthBars").GetComponent<HealthManager> ().healthcounter++;


			}
		}
	}
	public void Hinter(){
		HintText.SetActive (true);
	}
	public void Done(){
		GameObject.Find ("HealthBars").GetComponent<HealthManager> ().trackcount--;
		BgmHandler.main.ResumeMain(1.4f);
		GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().victor = 0;
		GameObject.Find ("Evelyn").GetComponent<InteractTrainer> ().defeated = true;
		GameObject.Find ("Evelyn").GetComponent<InteractTrainer> ().busy = false;
	/* 	StartCoroutine(BacktoWorld()); */
		CallLevelCavewithLightsTrueOrFalse1.SetActive (false);
	//	StartCoroutine(ScreenFade.main.Fade(true, 2f));
		Scene.main.Battle.gameObject.SetActive(false);
	}

/* 	IEnumerator BacktoWorld(){
		yield return new WaitForSeconds(0.4f);
		StartCoroutine(ScreenFade.main.Fade(true, 2f));
		CallTrueORFalse.SetActive (false);
		Scene.main.Battle.gameObject.SetActive(false);
	} */

}