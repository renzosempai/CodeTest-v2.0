using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickFast : MonoBehaviour {

	public int timeLeft;

	private int totalClicks = 0;

	public Text direction;
	public Text playerResult;
	public int click1;
	public int click2;
	public int click3;
	public GameObject bttn1;
	public GameObject bttn2;
	public GameObject bttn3;

	public GameObject btnDone;

	public GameObject boxBG;
	
	public GameObject CallClickFastMiniGame;

	// Use this for initialization
	void Start () {
		StartCoroutine("LoseTime");
	}
	public void Clicked(){
		click1++;
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
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().defeated = false;
		direction.text = ("Click all of the buttons appearing within "	+ timeLeft +	" seconds ");
		if (click1 == 7) {
			bttn1.SetActive (false);
			bttn2.SetActive (true);

		}
		if (click2 == 9) {
			bttn2.SetActive (false);
			bttn3.SetActive (true);

		}
		if (click3 == 5) {
			bttn3.SetActive (false);
			if (timeLeft > 0)
			{
				playerResult.text = "FINISHED";
				boxBG.SetActive(false);
				bttn1.SetActive (false);
				bttn2.SetActive (false);
				bttn3.SetActive (false);
				btnDone.SetActive(true);
			}else if (timeLeft == 0){
				StopCoroutine("LoseTime");
				playerResult.text = "YOU FAILED!";
				boxBG.SetActive(false);
				bttn1.SetActive (false);
				bttn2.SetActive (false);
				bttn3.SetActive (false);
				btnDone.SetActive(true);
				GameObject.Find ("HealthBars").GetComponent<HealthManager> ().healthcounter++;
			}
		}
	}


	public void Done(){
		BgmHandler.main.ResumeMain(1.4f);
		GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().victor = 0;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().defeated = true;
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().busy = false;
		CallClickFastMiniGame.SetActive (false);
		Scene.main.Battle.gameObject.SetActive(false);
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
