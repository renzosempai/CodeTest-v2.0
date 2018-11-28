using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour {

	List<string> questions = new List<string>() {"1 + 1 = 3"};

	List<string> correctAnswer = new List<string>() {"False"};



	public Transform resultObj;

	public Transform nextButtons;

	public static string selectedAnswer;

	public static string choiceSelected="n";

	public static int randQuestion = -1;

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
			
					resultObj.GetComponent<TextMesh> ().text = "Correct, click Next to continue";

					nextButtons.GetComponent<TextMesh> ().text = "Done";
				}
				if (correctAnswer [randQuestion] != selectedAnswer) {
			
					resultObj.GetComponent<TextMesh> ().text = "Wrong Answer";
					nextButtons.GetComponent<TextMesh> ().text = " ";

			
				}
			}
		}
	

}
