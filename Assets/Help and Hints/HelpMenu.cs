using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpMenu : MonoBehaviour {

	private bool running;

	// Use this for initialization
	void Start () {



	}
		

	public IEnumerator control(){
		//sceneTransition.FadeIn();
		StartCoroutine (ScreenFade.main.Fade (true, ScreenFade.defaultSpeed));
		running = true;


		while (running) {

			if (Input.GetButton("Back")) {
				//yield return new WaitForSeconds(sceneTransition.FadeOut());
				yield return StartCoroutine (ScreenFade.main.Fade (false, ScreenFade.defaultSpeed));
				running = false;

			}
			yield return null;
			this.gameObject.SetActive (false);
		}

}
}
