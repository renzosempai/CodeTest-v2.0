using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitscript : MonoBehaviour {

	void Update() {
		if (Input.anyKeyDown) {
			// I am assuming your start screen is level 0
			// The rest of the game would be level 1
			Application.Quit();
		}
	}
}
