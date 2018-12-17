using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySome : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (GameObject.Find ("ScenePause"));
		Destroy(GameObject.Find("BGMHandler"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
