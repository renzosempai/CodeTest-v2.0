﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuizHolder : MonoBehaviour {

	//	private string answer;
	private int counter;

	private int countGuess;

	[SerializeField]
	public GameObject btnDone;

	[SerializeField]
	public InputField input;

	[SerializeField]
	public Transform text;

	[SerializeField]
	public Text thistext;

	public string Question;


	public string Answer;
	private string sagot;

	void Awake(){

		sagot = Answer;

		text.GetComponent<Text> ().text = Question;

		//		text.text = "In C Programming, it is a variable that stores/points the address of another variable and is also used to allocate memory dynamically at run time. " +
		//			"Input the correct answer";


	}

	public void GetInput(string guess){
		CompareGuesses (guess);
		input.text = " ";
		countGuess++;

	}

	void CompareGuesses(string guess){
		if (guess == sagot) {

			thistext.text = "Correct Answer: " + guess + ", It took " + countGuess + " guesses";
			btnDone.SetActive (true);
			//			counter++;
		} else if (guess != sagot){
			thistext.text = "Wrong. Please guess again.";
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
}
