using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (GameObject.Find ("Bomb"));
		DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame

}
