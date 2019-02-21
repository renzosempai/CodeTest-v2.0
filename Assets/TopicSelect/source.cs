using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class source : MonoBehaviour {
	public GameObject topicshow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ClickForTopic(){
		topicshow.SetActive (true);
	}
	public void ClicktoHide(){
		topicshow.SetActive (false);
	}

}
