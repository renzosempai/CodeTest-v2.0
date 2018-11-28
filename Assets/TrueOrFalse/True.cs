using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class True : MonoBehaviour {

	List<string> firstchoice = new List<string>() {"True"};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = firstchoice [0];
	}
	
	// Update is called once per frame
	void Update () {

		if (TextController.randQuestion>-1){
			GetComponent<TextMesh> ().text = firstchoice [TextController.randQuestion];
		}
	}
	void OnMouseDown(){

		TextController.selectedAnswer = gameObject.name;
		TextController.choiceSelected = "y";
	}
}
