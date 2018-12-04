using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuizHolder : MonoBehaviour {

	private string answer;
	private int counter;

	private int countGuess;

	[SerializeField]
	public GameObject btnDone;

	[SerializeField]
	public InputField input;

	[SerializeField]
	public Text text;

	[SerializeField]
	public string Question;

	[SerializeField]
	public string Answer;

	void Awake(){
//		answer = "Pointers";
//		text.text = "In C Programming, it is a variable that stores/points the address of another variable and is also used to allocate memory dynamically at run time. " +
//			"Input the correct answer";


	}

	public void GetInput(string guess){
		CompareGuesses (guess);
		input.text = " ";
		countGuess++;
	
	}

	void CompareGuesses(string guess){
		if (guess == answer) {
			text.text = "Correct Answer: " + guess + ", It took " + countGuess + " guesses";
			btnDone.SetActive (true);
//			counter++;
		} else if (guess != answer) {
			text.text = "Wrong. Please guess again.";
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
