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
/* 
	public Text clickCounter; */

	// Use this for initialization
	void Start () {
		StartCoroutine("LoseTime");
	}
	
	// Update is called once per frame
	void Update () {
		direction.text = (" Click "	+ totalClickDirection + " times within "	+ timeLeft +	" seconds ");
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

	public void Clicked(){
		clickcounts++;
		Debug.Log(clickcounts);
	}

	public void Done(){
		GameObject.Find ("HealthBars").GetComponent<HealthManager> ().trackcount--;
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
