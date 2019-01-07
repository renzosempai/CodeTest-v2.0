using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectFemale : MonoBehaviour {
	public int firstF;
	public int secondF;
	public int thirdF;
	public int fourthF;
	public int fifthF;


	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}	
	public void CharSelected(){
		GameObject.Find ("Bomb").GetComponent<Destroyer> ().checker++;
		if (firstF == 1) {
			SceneManager.LoadScene ("FemaleLevel3");
			GameObject.Find ("Carrier").GetComponent<ToHold> ().countthis=1;
			GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().playerTrainer1Animation =
				Resources.LoadAll<Sprite> ("PlayerSprites/");
	

		} else if (secondF == 1) {
			SceneManager.LoadScene ("FemaleLevel2");
			GameObject.Find ("Carrier").GetComponent<ToHold> ().countthis=1;
			GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().playerTrainer1Animation =
				Resources.LoadAll<Sprite> ("PlayerSprites/");

		} else if (thirdF == 1) {
			SceneManager.LoadScene ("FemaleLevel4");
			GameObject.Find ("Carrier").GetComponent<ToHold> ().countthis=1;
			GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().playerTrainer1Animation =
				Resources.LoadAll<Sprite> ("PlayerSprites/");

		} else if (fourthF == 1) {
			SceneManager.LoadScene ("FemaleLevelCaveWithSpotLights");
			GameObject.Find ("Carrier").GetComponent<ToHold> ().countthis=1;
			GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().playerTrainer1Animation =
				Resources.LoadAll<Sprite> ("PlayerSprites/");
			
		} else if (fifthF == 1) {
			SceneManager.LoadScene ("FemaleLevelCaveWithLight");
			GameObject.Find ("Carrier").GetComponent<ToHold> ().countthis=1;
			GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().playerTrainer1Animation =
				Resources.LoadAll<Sprite> ("PlayerSprites/");
		}

//		GameObject.Find ("Player").GetComponent<PlayerMovement> ().spriteSheet = Resources.LoadAll<Sprite>("PlayerSprites/");
	}
}