using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCavewithLightsTrue : MonoBehaviour {

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

		LevelCavewithLightsTrueOrFalse.selectedAnswer = gameObject.name;
		LevelCavewithLightsTrueOrFalse.choiceSelected = "y";
	}
}