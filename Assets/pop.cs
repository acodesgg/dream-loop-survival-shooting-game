using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pop : MonoBehaviour {
	public GameObject window;
	public GameObject window1;
	public GameObject window2;
	public int minusscore;
	public Text messenge;
	public Text messenge1;
	public int weaponindex;
	bool buttonactive=true;

	// Use this for initial ization
	public void  show(string mess) {
		Debug.Log (ScoreManager.score);
		if (buttonactive && ScoreManager.score >= minusscore) {
			window.SetActive (true);
			messenge.text = mess;

		} else if ( buttonactive && ScoreManager.score <= minusscore) {
			window1.SetActive (true);
		} else if(!buttonactive){
			window2.SetActive (true);
		}
		//window.SetActive (true);
	}

	// Update is called once per frame
	public void Okay () {
		if (weaponindex == 1) {
			ScoreManager.score -= 10;
		weaponselected.weapon1 = true;
		}
		if (weaponindex == 2) {
			ScoreManager.score -= 20;
		weaponselected.weapon2 = true;
		}
		if (weaponindex == 3) {
			ScoreManager.score -= 50;
		weaponselected.weapon3= true;
		}
		if (weaponindex == 4) {
			ScoreManager.score -= 80;
		}




		buttonactive = false;
		window.SetActive (false);
	}
	public void Okay1 () {

		buttonactive = false;
		window1.SetActive (false);
	}
	public void Okay2 () {

		buttonactive = false;
		window2.SetActive (false);
	}

}
