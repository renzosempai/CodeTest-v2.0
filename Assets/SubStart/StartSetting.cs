using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSetting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private IEnumerator Options(){
		bool running = true;
		while (running)
		Scene.main.Settings.gameObject.SetActive(true);
		StartCoroutine(Scene.main.Settings.control());
		while (Scene.main.Settings.gameObject.activeSelf)
		{
			yield return null;
		}
}
}
