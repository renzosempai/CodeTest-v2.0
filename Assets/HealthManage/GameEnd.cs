using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour {
	public GameObject btnAgain;
	public GameObject btnExit;
	public GameObject GameEnder;

	public GameObject BGMdis;


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
	//	string thisScene = SceneManager.GetActiveScene ().name;
	//	SceneManager.LoadScene (thisScene);
		GameEnder.SetActive (false);
		SceneManager.LoadScene ("startup");



	}
	public void Exit(){

		Application.Quit();
		
	}
}
