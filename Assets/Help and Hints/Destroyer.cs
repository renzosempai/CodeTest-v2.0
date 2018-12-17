using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


	public class Destroyer : MonoBehaviour
	{
		//static Destroyer instance;
	public GameObject disabler;


void Start(){
		DontDestroyOnLoad (this);
		DontDestroyOnLoad (disabler);

		disabler.SetActive (false);

//		if (instance == null) {    
//			instance = this; // In first scene, make us the singleton.
//			DontDestroyOnLoad (gameObject);
//		} else if (instance != this) {
//			Destroy (gameObject); // On reload, singleton already set, so destroy duplicate.}
//		
//		} 

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


