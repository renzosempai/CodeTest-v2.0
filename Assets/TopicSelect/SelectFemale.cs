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
		if (firstF == 1) {
			SceneManager.LoadScene ("FemaleLevel3");
			GameObject.Find ("Carrier").GetComponent<ToHold> ().countthis++;
			GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().playerTrainer1Animation =
				Resources.LoadAll<Sprite> ("PlayerSprites/");

		} else if (secondF == 1) {
			SceneManager.LoadScene ("FemaleLevel2");
			GameObject.Find ("Carrier").GetComponent<ToHold> ().countthis++;
			GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().playerTrainer1Animation =
				Resources.LoadAll<Sprite> ("PlayerSprites/");
		} else if (thirdF == 1) {
			SceneManager.LoadScene ("FemaleLevel4");
			GameObject.Find ("Carrier").GetComponent<ToHold> ().countthis++;
			GameObject.Find ("SceneBattle").GetComponent<BattleHandler> ().playerTrainer1Animation =
				Resources.LoadAll<Sprite> ("PlayerSprites/");
		} else if (fourthF == 1) {
//			SceneManager.LoadScene (" ");
		} else if (fifthF == 1) {
//			SceneManager.LoadScene (" ");
		}

//		GameObject.Find ("Player").GetComponent<PlayerMovement> ().spriteSheet = Resources.LoadAll<Sprite>("PlayerSprites/");
	}
}