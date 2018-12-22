using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AnotherDestroyer : MonoBehaviour
{
	static AnotherDestroyer instance;
	public GameObject disable1;
	public int check;


	void Start(){
	//	checker = 0;
	}
	void Update(){
		DontDestroyOnLoad (this);



		if (check % 2 != 0) {
			disable1.SetActive (false);
		}
		else 
			disable1.SetActive(true);




		if (instance == null) {    
			instance = this; // In first scene, make us the singleton.
			DontDestroyOnLoad (gameObject);
		} else if (instance != this) {
			Destroy (gameObject); // On reload, singleton already set, so destroy duplicate.}

		} 

	}
}

//	public class Destroyer : MonoBehaviour
//	{
//		static Destroyer instance;
//
//		publi		c Destroyer GetInstance()
//		{
//			if(instance == null)
//			{
//				// Something similar to this to load and create the object when needed.
//				Object prefab = Resources.Load("Path/To/Prefab"); // Look up the docs ;)
//				GameObject go = Instantiate(prefab);
//				instance = GetComponent<MyBehaviour>();
//				DontDestroyOnLoad(go);
//			}
//			return instance;
//		} 
//	}


