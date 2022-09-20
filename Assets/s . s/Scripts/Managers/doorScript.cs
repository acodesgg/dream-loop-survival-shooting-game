using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour {

	public  bool zombie;
	public GameObject front;
	public EnemyManager ee;


	// Use this for initialization
	void Start () {


	}
	// Update is called once per frame
	void Update () {
		EnemyManager door = (EnemyManager)GetComponent ("EnemyManger");
		zombie =(bool)door._zombie2;
	
		print (zombie+"z1");
		if (zombie == true) {
			print ("door1 opened");
			front.SetActive (false);

			
		}
	}
}
