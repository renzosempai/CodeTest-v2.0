using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {

	private string answer;

	public int counter;

	private int countGuess;

	[SerializeField]
	public GameObject btn;

	[SerializeField]
	public GameObject btn2;

	[SerializeField]
	public InputField input;

	[SerializeField]
	public Text text;

	public static GameController creator;
	void Awake(){
		answer = "semicolon";
		text.text = "What is needed to end a code of line?";
	//	if (creator==null) {
		//	DontDestroyOnLoad (Done);
		//	creator = this;
	//	}


	}

	public void GetInput(string guess){
		CompareGuesses (guess);
		input.text = " ";
	
	
	}

	void CompareGuesses(string guess){
		if (guess == answer) {
			text.text = "Correct Answer: " + guess + ", It took " + countGuess + " guesses";
			btn.SetActive (true);
			counter++;

		} else if (guess != answer) {
			
			text.text = "Wrong. Please guess again.";
		}
		if (counter == 2){
			btn2.SetActive(true);

		}
		
	}
	public void PlayAgain(){
	
		answer = "string";
		text.text = "It is a type of input that is composed of characters:";
		countGuess = 0;
		btn.SetActive (false);
	}
	public void Done(){
		
		GameObject.Find ("Hold").GetComponent<BattleHandler> ().victor = +1;
		GameObject.Find ("Hold").GetComponent<InteractTrainer> ().defeated = true;
		SceneManager.LoadScene("overworldTest");

	}

}
