using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*
		float hVal = Input.GetAxis("Horizontal");
		float vVal = Input.GetAxis("Vertical");
		if(hVal != 0) {
			print("Horizontal movement selected: " + hVal);
		}
		if(vVal != 0) {
			print("Vertical movement selected: " + vVal);
		}


		if (Input.GetKey (KeyCode.M)) {
			print ("The 'M' KeyCode is pressed down");
		}


		if (Input.GetMouseButtonDown(4)) {
			print ("MouseButtonDown(0)");
		}
*/
		float hVal = Input.GetAxis("Mouse X");
		float vVal = Input.GetAxis("Mouse Y");
		if(hVal != 0) {
			print("Horizontal movement selected: " + hVal);
		}
		if(vVal != 0) {
			print("Vertical movement selected: " + vVal);
		}
	}
}
