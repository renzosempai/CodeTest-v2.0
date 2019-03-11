using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Press : MonoBehaviour {
 void Start()
    { 
		Screen.SetResolution (1980, 1080, false);
       // StartCoroutine(control());
    }
	void Update() {
		if (Input.anyKeyDown) {
			// I am assuming your start screen is level 0
			// The rest of the game would be level 1
			SceneManager.LoadScene("startup");
		}
	}
}
