using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour {
	public float xAxis;
	public float yAxis;
	public float speed;
	public float newX;
	public float size;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//move x y
		xAxis = Input.GetAxis ("Horizontal");
		yAxis = Input.GetAxis ("Vertical");
		transform.Translate (new Vector3(xAxis * Time.deltaTime * speed, yAxis * Time.deltaTime * speed, 0f));

		//rotate
		newX = Input.GetAxis ("Mouse X");
		transform.Rotate (new Vector3(0f, 0f, -newX));

		//change size
		if (Input.GetKey (KeyCode.M)) {
			transform.localScale += new Vector3(1.1f * Time.deltaTime, 1.1f * Time.deltaTime, 1.1f * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.N)) {
			transform.localScale -= new Vector3(1.1f * Time.deltaTime, 1.1f * Time.deltaTime, 1.1f * Time.deltaTime);
		}
	}
}
