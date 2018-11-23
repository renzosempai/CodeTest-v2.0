using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private string answer;
	private int counter;

	private int countGuess;

	[SerializeField]
	public GameObject btn;

	[SerializeField]
	public GameObject btn2;

	[SerializeField]
	public InputField input;

	[SerializeField]
	public Text text;

	void Awake(){
		answer = "semicolon";
		text.text = "What is needed to end a code of line?";
	}

	public void GetInput(string guess){
		CompareGuesses (guess);
		input.text = " ";
		countGuess++;
	
	}

	void CompareGuesses(string guess){
		if (guess == answer) {
			text.text = "Correct Answer: " + guess + ", It took " + countGuess + " guesses";
			btn.SetActive (true);
			counter++;
		} else if (guess != answer) {
			
			text.text = "Wrong. Please guess again.";
		}
		if (counter == 2) {
			btn2.SetActive (true);
		}
	}
	public void PlayAgain(){

		answer = "string";
		text.text = "It is a type of input that is composed of characters:";
		countGuess = 0;
		btn.SetActive (false);
	}
	public void Done(){

	//	GameObject.Find ("Hold").GetComponent<BattleHandler> ().victor = +1;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().defeated = true;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().busy = false;



	}
}
