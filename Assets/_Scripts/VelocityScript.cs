using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityScript : MonoBehaviour {
	public float startSpeed = 50;
	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3 (startSpeed, 0f, startSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
