using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {

	private string answer;
	private int counter;

	private int countGuess;

//	[SerializeField]
//	public GameObject btn;
	public GameObject wrong;

	[SerializeField]
	public GameObject btn2;

	[SerializeField]
	public InputField input;

	[SerializeField]
	public Text text;

void Awake(){
		answer = "Pointers";


	
	}
	public void GetInput(string guess){ 
		
			input.text = " ";
	
			CompareGuesses (guess);

			countGuess++;
	

	}

	void CompareGuesses(string guess){
		if (guess == answer) {
			text.text = "Correct Answer: " + guess + ", It took " + countGuess + " guesses";
			wrong.SetActive (false);
		}
//			counter++;
//	 else if (guess != answer) {
//
//
//			wrong.SetActive (false);
//		} 
		else {
			wrong.SetActive (true);
		}
//		if (counter == 2		) {
//			btn2.SetActive (true);
//		}
	}
//	public void PlayAgain(){
//
//		answer = "string";
//		text.text = "It is a type of input that is composed of characters:";
//		countGuess = 0;
//		btn.SetActive (false);
//	}
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
