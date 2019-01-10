using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour {
	public GameObject Setting;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Option(){
	//	Scene.main.Settings.gameObject.SetActive(true);
	//	this.gameObject.SetActive (false);
		//Setting.SetActive(true);
	}
	public void Quit(){
		Application.Quit ();
	}
}
