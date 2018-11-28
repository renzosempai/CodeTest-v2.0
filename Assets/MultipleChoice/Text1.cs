using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text1 : MonoBehaviour {

	List<string> firstchoice = new List<string>() {" one "};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = firstchoice [0];
	}
	
	// Update is called once per frame
	void Update () {

		if (TextControl.randQuestion>-1){
			GetComponent<TextMesh> ().text = firstchoice [TextControl.randQuestion];
		}
	}
	void OnMouseDown(){

		TextControl.selectedAnswer = gameObject.name;
		TextControl.choiceSelected = "y";
	}
}
