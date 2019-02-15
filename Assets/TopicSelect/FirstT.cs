using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FirstT : MonoBehaviour {
	public GameObject CharSelection;
	public GameObject Topics;
	public Vector3 transfer;

	// Use this for initialization
	void Start () {
	//	DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Topic(){


		CharSelection.SetActive (true);
		Topics.SetActive (false);
		GameObject.Find ("Male").GetComponent<SelectMale> ().firstM++;
		GameObject.Find ("Female").GetComponent<SelectFemale> ().firstF++;
		GlobalVariables.global.playerPosition = transfer;
		//PlayerMovement.player.transform.position = transfer;
	}

}
