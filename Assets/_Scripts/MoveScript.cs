using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {
	private GameControlh19 control;
	void Start () {
		control = GameObject.FindObjectOfType<GameControlh19> ();
	}
	void Update () {
		transform.Translate (0, 0, control.startSpeed);
	}

}
