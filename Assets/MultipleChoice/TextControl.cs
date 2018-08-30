using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControl : MonoBehaviour {
	List<string> questions = new List<string>(){"1+1 =", "2+2 =", "3+3 =", "4+4 =", "5+5 ="};

	List<string> correctAnswer = new List<string>() {"4","1","2","4","3"};

	public Transform resultsObj;

	public static string selectedAnswer;

	public static string choiceSelected="n";

	public static int randQuestion=-1;

	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = questions [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (randQuestion == -1) 
		{
			randQuestion = Random.Range (0, 5);
		}
		if (randQuestion>-1)
		{
		GetComponent<TextMesh> ().text = questions [randQuestion];
		}
		//Debug.Log (questions [randQuestion]);
		if (choiceSelected == "y") {
			choiceSelected = "n";
			if (correctAnswer [randQuestion] == selectedAnswer)
			{
				resultsObj.GetComponent<TextMesh> ().text = "Correct! Click next to continue";
			}
			if (correctAnswer [randQuestion] != selectedAnswer)
				{
					resultsObj.GetComponent<TextMesh> ().text = "Wrong";
				}
		}
	}
}
