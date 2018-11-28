using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour {

	List<string> questions = new List<string> () { " " };
	List<string> correctAnswer = new List<string>() {"False"};



	public Transform resultObj;
	public GameObject hider1;
	public GameObject hider2;

	public static string selectedAnswer;

	public static string choiceSelected="n";

	public static int randQuestion = -1;

	public GameObject btn2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (randQuestion == -1) {
			randQuestion = Random.Range (0, 2);
		}

		if  (randQuestion > -1) {
				GetComponent<TextMesh> ().text = questions [randQuestion];
			}
			//Debug.Log (questions [randQuestion]);
			if (choiceSelected == "y") {

				choiceSelected = "n"; 
				if (correctAnswer [randQuestion] == selectedAnswer) {
			
					resultObj.GetComponent<TextMesh> ().text = "Correct, click Done to continue";


				btn2.SetActive (true);
				}
				if (correctAnswer [randQuestion] != selectedAnswer) {
			
					resultObj.GetComponent<TextMesh> ().text = "Wrong Answer";


			
				}
			}
		}
	public void Done(){
		resultObj.GetComponent<TextMesh> ().text = "HUMANAG CLICK ANG DONE";
		hider1.SetActive (false);
		hider2.SetActive (false);
	}

}
