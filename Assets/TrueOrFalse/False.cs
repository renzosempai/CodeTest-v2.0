using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class False: MonoBehaviour {

	List<string> secondchoice = new List<string>() {"False"};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = secondchoice [0];
	}
	// Update is called once per frame
	void Update () {

		if (TextController.randQuestion>-1){
			GetComponent<TextMesh> ().text = secondchoice [TextController.randQuestion];
		}
	}

	void OnMouseDown(){

		TextController.selectedAnswer = gameObject.name;
		TextController.choiceSelected = "y";
	}
}
