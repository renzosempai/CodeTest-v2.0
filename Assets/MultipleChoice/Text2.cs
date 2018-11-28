using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text2 : MonoBehaviour {

	List<string> secondchoice = new List<string>() {" three "};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = secondchoice [0];
	}
	// Update is called once per frame
	void Update () {

		if (TextControl.randQuestion>-1){
			GetComponent<TextMesh> ().text = secondchoice [TextControl.randQuestion];
		}
	}

	void OnMouseDown(){

		TextControl.selectedAnswer = gameObject.name;
		TextControl.choiceSelected = "y";
	}
}
