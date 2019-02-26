using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level4True1 : MonoBehaviour {

//	List<string> secondchoice = new List<string>() {"True"};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = secondchoice [0];
	}
	// Update is called once per frame
	void Update () {
//
//		if (MainText.randQuestion>-1){
//			GetComponent<Text> ().text = secondchoice [MainText.randQuestion];
//		}
	}

	public void Answer(){

		Level4TrueOrFalse1.selectedAnswer = gameObject.name;
		Level4TrueOrFalse1.choiceSelected = "y";
	}
}