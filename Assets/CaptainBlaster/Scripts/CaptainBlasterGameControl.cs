using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CaptainBlasterGameControl : MonoBehaviour {

	public Text scoreText, gameOverText; // Note we declare two text elements here
	int playerScore = 0;

	public void PlayerDied () {
		gameOverText.enabled = true; // Display the Game Over! Text
		Time.timeScale = 0; // This freezes the game
	}

	public void AddScore () {
		playerScore++;
		scoreText.text = playerScore.ToString();
	}
}
