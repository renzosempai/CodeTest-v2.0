using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToHold : MonoBehaviour {

	// Use this for initialization
	public int countthis;
	// Update is called once per frame
	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
	}
	void Update(){
		if (countthis == 1) {
			GameObject.Find ("Player").GetComponent<PlayerMovement> ().spriteSheet = Resources.LoadAll<Sprite> ("FemaleSprites/");
		}
	
	}
}
