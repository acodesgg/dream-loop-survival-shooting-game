using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class winCondition : MonoBehaviour {
	public static bool zombie = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			print ("win");
			SceneManager.LoadScene ("testingcone");
		}
	}
}
