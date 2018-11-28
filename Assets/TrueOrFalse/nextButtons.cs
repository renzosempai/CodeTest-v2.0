using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextButtons : MonoBehaviour {




	public int score = 0;

	public Transform result;
	public GameObject donee;
	public Transform nonext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{

		TextController.randQuestion = -1;
		score++;

		result.GetComponent<TextMesh> ().text = " ";
		nonext.GetComponent<TextMesh> ().text = " ";
		if (score == 1) {
			donee.SetActive (true);
		}



	}
}
