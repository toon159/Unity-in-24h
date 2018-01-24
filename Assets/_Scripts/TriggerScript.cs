using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		print(other.gameObject.name + " has entered");
	}
	void OnTriggerStay (Collider other) {
		print(other.gameObject.name + " is still");
	}
	void OnTriggerExit (Collider other) {
		print(other.gameObject.name + " has left");
	}
}
