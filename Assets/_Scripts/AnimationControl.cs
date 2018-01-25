using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour {

	private Animator anim;
	void Start () {
		//Get a reference to the animator
		anim = GetComponent<Animator> ();
	}
	void Update () {
		anim.SetFloat ("Speed", Input.GetAxis ("Vertical"));
		anim.SetFloat ("Direction", Input.GetAxis( "Horizontal"));
	}
}
