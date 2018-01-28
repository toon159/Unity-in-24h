using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {
	public float speed = .5f;

	private Renderer groundRenderer;

	// Use this for initialization
	void Start () {
		groundRenderer = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		float offset = (Time.time * speed % 1)/4;  
		groundRenderer.material.mainTextureOffset = new Vector2 (0, -offset);
	}

	public void SlowDown(){
		speed = speed / 2;
	}

	public void SpeedUp(){
		speed = speed * 2;
	}
}
