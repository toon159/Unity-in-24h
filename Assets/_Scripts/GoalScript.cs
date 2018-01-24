using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider collider){
		GameObject colliderdWith = collider.gameObject;

		if (colliderdWith.tag == gameObject.tag) {
			GetComponent<Light> ().intensity = 0;
			Destroy (colliderdWith);
		}
	}


}
