using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThirdT : MonoBehaviour {

	public GameObject CharSelection;
	public GameObject Topics;
	public Vector3 transfer; 
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void Topic(){
		CharSelection.SetActive (true);
		Topics.SetActive (false);
		GameObject.Find ("Male").GetComponent<SelectMale> ().thirdM++;
		GameObject.Find ("Female").GetComponent<SelectFemale> ().thirdF++;
		GlobalVariables.global.playerPosition = transfer;
	}
}
