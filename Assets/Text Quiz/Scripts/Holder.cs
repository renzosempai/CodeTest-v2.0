using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour {

	// Use this for initialization
	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}

}
