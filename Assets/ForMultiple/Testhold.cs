using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testhold : MonoBehaviour {

	List<string> questions = new List<string>() {"1 + 1 = ?"};

	List<string> correctAnswer = new List<string>() {"4"};

//	public Text textquest;

	public RectTransform resultsObj;


	public GameObject btn;


	public static string selectedAnswer;

	public static string choiceSelected="n";

	public static int randQuestion = -1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (randQuestion == -1) {
			randQuestion = Random.Range (0, 1);
		}

		if  (randQuestion > -1) {
			GetComponent<Text> ().text = questions [randQuestion];
		}
		//Debug.Log (questions [randQuestion]);
		if (choiceSelected == "y") {

			choiceSelected = "n"; 
			if (correctAnswer [randQuestion] == selectedAnswer) {

				resultsObj.GetComponent<Text> ().text = "Correct, click Done to continue";
				btn.SetActive (true);

			}
			if (correctAnswer [randQuestion] != selectedAnswer) {

				resultsObj.GetComponent<Text> ().text = "Wrong Answer";
//				StartCoroutine(Wait());

			}
		}
	}
	public void Done(){
		BgmHandler.main.ResumeMain(1.4f);
		GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().victor = 0;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().defeated = true;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().busy = false;
		StartCoroutine(BacktoWorld());
	}

	IEnumerator BacktoWorld(){
		yield return new WaitForSeconds(0.4f);
		StartCoroutine(ScreenFade.main.Fade(true, 2f));
		Scene.main.Battle.gameObject.SetActive(false);
	}
		
//	IEnumerator Wait(){
//		yield return new WaitForSeconds(0.4f);
//	}
}