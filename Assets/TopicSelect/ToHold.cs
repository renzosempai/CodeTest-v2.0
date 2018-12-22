using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToHold : MonoBehaviour {
	static ToHold instance;
	// Use this for initialization
	public int countthis;
	public static int counter;

	// Update is called once per frame
	void Start(){
		counter++;
		if (counter == 1) {
			GameObject.Find ("Bomb").GetComponent<Destroyer> ().checker++;

		}
	}
	void Awake() {
		
		DontDestroyOnLoad (transform.gameObject);
	}
	void Update(){
		
		if (countthis > 0) {
			GameObject.Find ("Player").GetComponent<PlayerMovement> ().spriteSheet = Resources.LoadAll<Sprite> ("FemaleSprites/");
		}
	
		if (instance == null) {    
			instance = this; // In first scene, make us the singleton.
			DontDestroyOnLoad (gameObject);
		} else if (instance != this) {
			Destroy (gameObject); // On reload, singleton already set, so destroy duplicate.}

		} 

	
	}
}
