using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {
	public GameObject imagehide;
	public GameObject btHide;
	public GameObject texthide;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void PlayNow(){
		imagehide.SetActive(false);
		btHide.SetActive (false);
		texthide.SetActive (false);
	}
}
