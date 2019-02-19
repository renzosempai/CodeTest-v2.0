using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickFast : MonoBehaviour {

	public int timeLeft = 0;

	private int totalClicks = 0;

	public Text durationTextOver;
	public Text direction;
	public int totalClickDirection;
	public Text timeOver;
	public int clickcounts;
	public int click2;
	public int click3;
	public GameObject bttn1;
	public GameObject bttn2;
	public GameObject bttn3;
/* 
 
	public Text clickCounter; */

	// Use this for initialization
	void Start () {
		StartCoroutine("LoseTime");
	}
	public void Clicked(){
		clickcounts++;
		Debug.Log ("btn 1 was clicked");
	}

	public void ClickedTwo(){
		click2++;
		Debug.Log ("btn 2 was clicked");
	}
	public void ClickedThree(){
		click3++;
		Debug.Log ("btn 3 was clicked");
	}
	// Update is called once per frame
	void Update () {
		direction.text = (" Click "	+ totalClickDirection + " times within "	+ timeLeft +	" seconds ");

		if (clickcounts == 7) {
			bttn1.SetActive (false);
			bttn2.SetActive (true);

		}
		if (click2 == 9) {
			bttn2.SetActive (false);
			bttn3.SetActive (true);

		}
		if (click3 == 5) {
			bttn3.SetActive (false);
			Debug.Log ("all done");
		}
	}

	public void ProceedORTerminate()
	{
		if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            timeOver.text = "TIME'S UP!";
			GameObject.Find ("HealthBars").GetComponent<HealthManager> ().healthcounter++;
			
        }
	}



	public void Done(){
	//	GameObject.Find ("HealthBars").GetComponent<HealthManager> ().trackcount--;
		BgmHandler.main.ResumeMain(1.4f);
		GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().victor = 0;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().defeated = true;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().busy = false;
		/* StartCoroutine(BacktoWorld()); */
		/* CallClickFastMiniGame.SetActive (false); */
	//	StartCoroutine(ScreenFade.main.Fade(true, 2f));
		/* Scene.main.Battle.gameObject.SetActive(false); */
	}

	IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
