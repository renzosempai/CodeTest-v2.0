using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour {

	public int timeLeft = 0;
    public Text countdownText;

	public Text durationTextOver;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Time Left: " + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            durationTextOver.text = "TIME'S UP!";
        }
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
