using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2GuessTracker3 : MonoBehaviour {
	public Transform text;
	public Text guess;
	public int guesscount;
//	public GameObject health1;
	public GameObject hidecount;


	// Use this for initialization
	void Start () {
		guesscount = 2;
	}
	
	// Update is called once per frame
	void Update () {
		
		guess.text = "Guesses: " + guesscount; 
		if (guesscount == 0) {
		//	health1.SetActive (false);
			GameObject.Find ("NotQuestions").GetComponent<Level2GiveLife> ().monitor++;
			hidecount.SetActive (false);
			GameObject.Find ("HealthBars").GetComponent<HealthManager> ().healthcounter++;
		}
	}
}
