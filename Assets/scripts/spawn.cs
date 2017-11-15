using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public Transform[] spawnPoint, spawnPoint2, spawnPoint3;
	public GameObject t1, t2, candy;
	private int rand, i;

	void Start () {
		InvokeRepeating ("start2", 2.5f, 1.25f);
	}

	void start2 () {
		Spawn ();
	}

	void Spawn () {
		rand = Random.Range (0, spawnPoint.Length);
		i++;

		Transform pos1 = spawnPoint[rand]; 
		Transform pos2 = spawnPoint2[rand];
		Transform pos3 = spawnPoint3[rand];

		Instantiate (t1, pos1.position, pos1.rotation);
		Instantiate (t2, pos2.position, pos2.rotation);

		if (i % 4 == 0 || i % 7 == 0 || i % 11 == 0) 
			Instantiate (candy, pos3.position, pos3.rotation);
	}
}
