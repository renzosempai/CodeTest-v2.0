using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour {
	public GameObject btnAgain;
	public GameObject btnExit;
	public GameObject GameEnder;


	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (btnAgain);
		DontDestroyOnLoad (btnExit);



	}
	
	// Update is called once per frame
	void Update () {

	}
	public void Restart(){


		SceneManager.LoadScene ("startup");

		GameEnder.SetActive (false);

	}
	public void Exit(){

		Application.Quit();
		
	}
}
