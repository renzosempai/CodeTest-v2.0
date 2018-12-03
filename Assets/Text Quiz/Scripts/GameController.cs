using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private DialogBoxHandler Dialog;

	public string[] trainerPostDefeatDialog;

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
		BgmHandler.main.ResumeMain(1.4f);
		GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().victor = 0;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().defeated = true;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().busy = false;
		StartCoroutine(DefeatDialogue());
		StartCoroutine(BacktoWorld());
	}

	IEnumerator DefeatDialogue(){
		if (Scene.main.Battle.victor == 0)
		{
			//Display all of the defeated Dialog. (if any)
			for (int i = 0; i < trainerPostDefeatDialog.Length; i++)
			{
				Dialog.drawDialogBox();
				yield return Dialog.StartCoroutine("drawText", trainerPostDefeatDialog[i]);
				while (!Input.GetButtonDown("Select") && !Input.GetButtonDown("Back"))
				{
					yield return null;
				}
				Dialog.undrawDialogBox();
			}
		}
	}

	IEnumerator BacktoWorld(){
//		StartCoroutine(ScreenFade.main.Fade(true, 1f));
		yield return new WaitForSeconds(1.6f);
		Scene.main.Battle.gameObject.SetActive(false);
	}
}
