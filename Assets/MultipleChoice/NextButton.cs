using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour {
	public Transform resultsObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		TextControl.randQuestion = -1;
		resultsObj.GetComponent<TextMesh> ().text = "   ";
	}
}
