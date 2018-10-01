using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextButton : MonoBehaviour {

	public Transform scorePanel;

	public int score = 0;

	public Transform result;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{

		TextControl.randQuestion = -1;
		score++;
		scorePanel.GetComponent<TextMesh> ().text = " "+score;
		result.GetComponent<TextMesh> ().text = " ";

	}
}
