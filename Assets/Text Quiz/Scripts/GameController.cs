using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private string num;


	private int countGuess;

	[SerializeField]
	public GameObject btn;

	[SerializeField]
	public InputField input;

	[SerializeField]
	public Text text;

	void Awake(){
		num = "semicolon";
		text.text = "What is needed to end a code of line?";
	}

	public void GetInput(string guess){
		CompareGuesses (guess);
		input.text = " ";
		countGuess++;
	
	}

	void CompareGuesses(string guess){
		if (guess == num) {
			text.text = "Correct Answer: " + guess + ", It took " + countGuess + " guesses";
			btn.SetActive (true);

		} else if (guess != num) {
			
			text.text = "Wrong. Please guess again.";
		}
	}
	public void PlayAgain(){
	
		num = "string";
		text.text = "It is a type of input that is composed of characters:";
		countGuess = 0;
		btn.SetActive (false);
	}
}
