﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectFemale : MonoBehaviour {
	public int firstF;
	public int secondF;
	public int thirdF;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void CharSelected(){
		if (firstF == 1) {
			SceneManager.LoadScene ("Level1Indoors");
		} else if (secondF == 1) {
			SceneManager.LoadScene ("Level1");
		} else if (thirdF == 1) {
			SceneManager.LoadScene ("Level2");
		}
	}
}
