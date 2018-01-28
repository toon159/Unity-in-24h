using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class h19_player : MonoBehaviour {

	public GameControlh19 control;
	private Animator anim;
	public float strafeSpeed = 4f;
	private bool jumping = false;
	void Start () {
		anim = GetComponent<Animator>();
	}
	void Update () {
		float xMove = Input.GetAxis ("Horizontal") * Time.deltaTime * strafeSpeed;
		transform.Translate (xMove, 0f, 0f);
		if (transform.position.x > 3) {
			transform.Translate (3f, 0, 0);
		} else if (transform.position.x < -3) {
			transform.Translate (-3f, 0, 0);
		}
		if (Input.GetButtonDown ("Jump")) {
			anim.SetTrigger ("Jump");
		}
		if (anim.GetCurrentAnimatorStateInfo(0).IsName ("Run")) {
			jumping = false;
		} else {
			jumping = true;
		}

	}
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.name == "Powerup(Clone)") {
			control.PowerupCollected ();
		} else if(other.gameObject.name == "Obstacle(Clone)" && ! jumping) {
			control.SlowWorldDown ();
		}
		Destroy (other.gameObject);
	}
}
