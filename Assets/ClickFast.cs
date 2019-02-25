using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickFast : MonoBehaviour {

	public int timeLeft;
	private int totalClicks;
	private int click1;
	
	public int ClickAmount;

	public Text direction;
	public Text playerResult;
	public Text directionText;

	public GameObject bttn1;
	public GameObject btnDone;
	public GameObject CallClickFastMiniGame;

	// Use this for initialization
	void Start () {
		StartCoroutine("LoseTime");
	}
	public void Clicked(){
		click1++;
		Debug.Log ("I was clicked " + click1 + " times");
	}

	// Update is called once per frame
	void Update () {
		GameObject.Find ("TrainerCole").GetComponent<InteractTrainer> ().defeated = false;

		direction.text = ("Warning! You have about "	+ timeLeft +	" seconds to click the button " + ClickAmount + 
							" times as fast as you can, or you're in for a world of hurt.");

		directionText.text = ("Total Clicks: " + click1);

		if (timeLeft <= 1)
		{
			direction.text = ("Warning! You have about "	+ timeLeft +	" second to click the button " + ClickAmount + 
								" times as fast as you can, or you're in for a world of hurt.");
		}

		if (click1 == ClickAmount){
			if(timeLeft > 0){
				StopCoroutine("LoseTime");
				bttn1.SetActive(false);
				playerResult.text = "Perfect!";
				StartCoroutine("WaitToAppear");
			} 
		}
		else{ 
			if(timeLeft <= 0){
				StopCoroutine("LoseTime");
				bttn1.SetActive(false);
				playerResult.text = "You have failed this minigame!";
				StartCoroutine("WaitToAppear");
			}
		}
	}

	public void MiniDone(){
		if(timeLeft <= 0){
			GameObject.Find ("HealthBars").GetComponent<HealthManager> ().healthcounter++;
		}
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

	IEnumerator WaitToAppear(){
		yield return new WaitForSeconds(1f); 
		btnDone.SetActive(true);
	}

}
