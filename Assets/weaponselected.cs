using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponselected : MonoBehaviour {
	public int selectedWeapons = 0;
	public int [] weaponss;
	public static bool weapon1=false, weapon2=false, weapon3=false;
	public int gun1=5,gun2=6,gun3=7;
	// Use this for initialization
	void Start () {
		selectedWeapon ();
	}

	// Update is called once per frame
	void Update () {
		int previousSelected = selectedWeapons;
		if (Input.GetAxis ("Mouse ScrollWheel") > 0f) {
			if (selectedWeapons >= transform.childCount - 1)
				selectedWeapons = 0;
			else
				selectedWeapons++;

		}
		if (Input.GetAxis ("Mouse ScrollWheel") < 0f) {
			if (selectedWeapons <= 0f)
				selectedWeapons = transform.childCount - 1;
			else
				selectedWeapons--;

		}
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			selectedWeapons = 0;
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)&& transform.childCount>=2) {
			selectedWeapons = 1;
		}	if (Input.GetKeyDown (KeyCode.Alpha3)&& transform.childCount>=3) {
			selectedWeapons = 2;
		}
		if (previousSelected != selectedWeapons) {
			selectedWeapon ();
		}
		Debug.Log (transform.childCount);

	}
	void selectedWeapon(){
		int i = 0;
		if (weapon1) {
			gun1=0;

		}
		if (weapon2) {
			gun2=1;

		}
		if (weapon3) {
			gun3=2;

		}
		foreach (Transform weapon in transform) {
			if (i == gun1 || i == gun2|| i == gun3) {
				if (i == selectedWeapons) {
					weapon.gameObject.SetActive (true);
				} else {
					weapon.gameObject.SetActive (false);
				}
			}
			i++;
		}
	}

}
