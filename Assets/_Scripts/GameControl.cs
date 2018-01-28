using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl1 : MonoBehaviour {

	// Note you can define several variables of the same type on one line
	public GameObject blueBall, greenBall, redBall, orangeBall;
	private bool isGameOver = false;
	// Update is called once per frame
	void Update () {
		// If all four balls are not (!) existent then game is over
		isGameOver = !blueBall&& !greenBall&& !redBall&& !orangeBall;
	}
	void OnGUI(){
		if(isGameOver){
			Rect rect = new Rect(Screen.width / 2 - 100,Screen.height / 2 - 50, 200, 75);
			GUI.Box(rect, "Game Over");
			Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
			GUI.Label (rect2, "Good Job!");
		}
	}
}
