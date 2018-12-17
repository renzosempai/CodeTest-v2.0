using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMact : MonoBehaviour {
	static BGMact instance;
	public GameObject forbgm;
	public GameObject antibomb;
	// Use this for initialization
	void Start () {
		forbgm.SetActive (true);
		DontDestroyOnLoad (forbgm);
		DontDestroyOnLoad (antibomb);
		DontDestroyOnLoad (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		antibomb.SetActive (false);
		forbgm.SetActive (true);
		if (instance == null) {    
			instance = this; // In first scene, make us the singleton.
			DontDestroyOnLoad (gameObject);
		} else if (instance != this) {
			Destroy (gameObject); // On reload, singleton already set, so destroy duplicate.}

		} 
	}
}
