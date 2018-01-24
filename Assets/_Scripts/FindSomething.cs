using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindSomething : MonoBehaviour {
	private HelloWorld helloWorld;
	private GameObject SphereTag;
	private GameObject SphereName;

	// Use this for initialization
	void Start () {
		helloWorld = GameObject.FindObjectOfType<HelloWorld>();
		SphereTag = GameObject.FindGameObjectWithTag ("Player");
		SphereName = GameObject.Find ("SphereTest");
	}
	
	// Update is called once per frame
	void Update () {
		//SphereType.transform.Translate (Vector3.forward * Time.deltaTime);
		SphereTag.transform.Translate (Vector3.forward * Time.deltaTime);
		SphereName.transform.Translate (Vector3.forward * Time.deltaTime);
	}
}
