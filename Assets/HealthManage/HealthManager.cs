using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour {
	public GameObject HealthIcon;
	public GameObject HealthIcon1;
	public GameObject HealthIcon2;
	public GameObject HealthIcon3;
	public GameObject HealthIcon4;
	//add health:
	public GameObject addHealth;

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
		DontDestroyOnLoad (HealthIcon3);
		DontDestroyOnLoad (HealthIcon4);
	}
	
	// Update is called once per frame
	void Update () {
		tracker.text = "Exercises Left: " + trackcount;

		if (healthcounter == 1) {
			HealthIcon.SetActive (false);
	
		}else
			HealthIcon.SetActive (true);
		
		if (healthcounter == 2) {
			HealthIcon1.SetActive (false);
		}else
			HealthIcon1.SetActive (true);
		if (healthcounter == 3) {
			HealthIcon2.SetActive (false);		

		}else
			HealthIcon2.SetActive (true);
		if (healthcounter == 4) {
			HealthIcon3.SetActive (false);

		}else
			HealthIcon3.SetActive (true);
		if(healthcounter == 5){
			HealthIcon4.SetActive (false);
		}else
			HealthIcon4.SetActive (true);
		if (healthcounter >= 5) {
			endcount.SetActive (true);
		}
//		if (healthcounter == 0) {
//			HealthIcon.SetActive (true);
//		}
			
		if (trackcount == 0) {
			SceneManager.LoadScene ("Completed");
		}

	}



}
