using UnityEngine;
using System.Collections;
public class MeteorSpawn : MonoBehaviour {
	
	public float minSpawnDelay = 1f;
	public float maxSpawnDelay = 3f;
	public GameObject meteorPrefab;
	
	void Start () {
		Spawn ();
	}

	void Spawn () {
		// Create a meteor at a random x position
		Vector3 spawnPos = transform.position + new Vector3(Random.Range(-6, 6), 0, 0);
		Instantiate (meteorPrefab, spawnPos, Quaternion.identity);
		Invoke ("Spawn", Random.Range (minSpawnDelay, maxSpawnDelay));
	}
}
