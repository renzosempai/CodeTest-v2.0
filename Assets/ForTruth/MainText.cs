﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainText : MonoBehaviour {

	List<string> questions = new List<string> () { " " };
	List<string> correctAnswer = new List<string>() {" "};
	public GameObject CallTrueORFalse;

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
		correctAnswer = TheAnswer;
		DontDestroyOnLoad (btnHint);
		DontDestroyOnLoad (HintText);
	}

	// Update is called once per frame
	void Update () {
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().defeated = false;
		if (randQuestion == -1) {
			randQuestion = Random.Range (0, 2);
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
			}
			if (correctAnswer [randQuestion] != selectedAnswer) {

				resultObj.GetComponent<Text> ().text = "Wrong Answer";
				btnHint.SetActive (true);


			}
		}
	}
	public void Hinter(){
		HintText.SetActive (true);
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
		CallTrueORFalse.SetActive (false);
		Scene.main.Battle.gameObject.SetActive(false);
	}

}