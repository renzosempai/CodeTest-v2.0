﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour {
	public GameObject btnAgain;
	public GameObject btnExit;
	public GameObject GameEnder;
	public Vector3 transferPosition;
	public int transferDirection;


	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (btnAgain);
		DontDestroyOnLoad (btnExit);
		DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	public void Restart(){
		
		//int scene = SceneManager.GetActiveScene().buildIndex;
		//SceneManager.LoadScene(scene, LoadSceneMode.Single);
			string thisScene = SceneManager.GetActiveScene ().name;
			SceneManager.LoadScene (thisScene);
		//BgmHandler.main.ResumeMain(1.4f);
		//StartCoroutine(BacktoWorld());
		BgmHandler.main.ResumeMain(1.4f);
/* 		Scene.main.Battle.gameObject.SetActive (false); */
		GameEnder.SetActive (false);
		GlobalVariables.global.playerPosition = transferPosition;
		 GlobalVariables.global.playerDirection = transferDirection;
		PlayerMovement.player.transform.position = transferPosition;
		PlayerMovement.player.updateDirection(transferDirection);
		//GameObject.Find ("Bomb").GetComponent<Destroyer> ().checker++;
		//SceneManager.LoadScene ("startup");
	}

	public void Exit(){

		Application.Quit();
		
	}
}
