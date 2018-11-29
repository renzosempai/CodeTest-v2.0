using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Falsee : MonoBehaviour {

	List<string> secondchoice = new List<string>() {"False"};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = secondchoice [0];
	}
	// Update is called once per frame
	void Update () {

		if (TextController.randQuestion>-1){
			GetComponent<Text> ().text = secondchoice [MainText.randQuestion];
		}
	}

	void OnMouseDown(){

		MainText.selectedAnswer = gameObject.name;
		MainText.choiceSelected = "y";
	}
}