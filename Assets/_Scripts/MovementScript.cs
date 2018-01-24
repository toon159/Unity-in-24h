using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mX = Input.GetAxis("Horizontal") / 10;
		float mY = Input.GetAxis("Vertical") / 10;
		transform.Translate(mX, mY, 0);
	}
}
