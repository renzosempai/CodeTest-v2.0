using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMale : MonoBehaviour {
	public int firstM;
	public int secondM;
	public int thirdM;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void CharSelected(){

		if (firstM == 1) {
			SceneManager.LoadScene ("Level1Indoors");
		} else if (secondM == 1) {
			SceneManager.LoadScene ("Level1"); 

		} else if (thirdM == 1) {
			SceneManager.LoadScene ("Level2");
		}
	}
}
