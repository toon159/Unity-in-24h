using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float speed = 10f;
	private CaptainBlasterGameControl gameController; // Note this is private this time
	// Use this for initialization
	void Start () {
		// Because the bullet doesn't exist until the game is running
		// we must find the Game Controller a different way.
		gameController = GameObject.FindObjectOfType<CaptainBlasterGameControl> ();
	}
	// Update is called once per frame
	void Update () {
		transform.Translate (0f, speed * Time.deltaTime, 0f); // Move up
	}
	void OnCollisionEnter2D (Collision2D other) {
		Destroy (other.gameObject); // Destory the meteor
		gameController.AddScore (); // Increment the score
		Destroy (gameObject); // Destroy the bullet
	}
}