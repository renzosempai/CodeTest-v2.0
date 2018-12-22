using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {
	public GameObject HealthIcon;
	public GameObject HealthIcon1;
	public GameObject HealthIcon2;
	public int healthcounter;
	public Transform text;
	public Text tracker;
	public int trackcount;
	public GameObject endcount;
	// Use this for initialization
	void Start () {
		trackcount = 10;
		healthcounter = 0;
		DontDestroyOnLoad (HealthIcon);
		DontDestroyOnLoad (HealthIcon1);
		DontDestroyOnLoad (HealthIcon2);
	}
	
	// Update is called once per frame
	void Update () {
		tracker.text = "Remaining NPC: " + trackcount;
		if (healthcounter >= 1) {
			HealthIcon.SetActive (false);
		}
		if (healthcounter >= 2) {
			HealthIcon1.SetActive (false);
		}
		if (healthcounter >= 3) {
			HealthIcon2.SetActive (false);		

		}
		if (healthcounter == 3) {
			endcount.SetActive (true);
		}
	}

}
