﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyChoice : MonoBehaviour {


//	List<string> firstchoice = new List<string>() {" one "};
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

		MiniGameScript.selectedAnswer = gameObject.name;
		MiniGameScript.choiceSelected = "y";
	}

}
