﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdC : MonoBehaviour {

//	List<string> firstchoice = new List<string>() {" three "};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = firstchoice [0];
	}

	// Update is called once per frame
	void Update () {
//
//		if (Testhold.randQuestion>-1){
//			GetComponent<Text> ().text = firstchoice [Testhold.randQuestion];
//		}
	}
	public void Answer(){

		Testhold.selectedAnswer = gameObject.name;
		Testhold.choiceSelected = "y";
		Debug.Log ("clicked 3");
	}
}
