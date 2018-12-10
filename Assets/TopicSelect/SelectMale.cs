using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMale : MonoBehaviour {
	public int firstM;
	public int secondM;
	public int thirdM;
	public int fourthM;
	public int fifthM;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void CharSelected(){

		if (firstM == 1) {
			SceneManager.LoadScene ("Level3");
		} else if (secondM == 1) {
			SceneManager.LoadScene ("Level2"); 

		} else if (thirdM == 1) {
			SceneManager.LoadScene ("Level4");
		} else if (fourthM == 1) {
//			SceneManager.LoadScene (" ");
		} else if (fifthM == 1) {
//			SceneManager.LoadScene (" ");
		}
	}
}
