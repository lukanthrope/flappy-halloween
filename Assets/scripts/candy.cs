using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class candy : MonoBehaviour {

	private float speed = 5.5f;

	void FixedUpdate () {
		transform.Translate (Vector2.left * speed * Time.deltaTime);
	}

	void Start () {
		Invoke ("Destr", 20);
	}

	void Destr () {
		Destroy (gameObject);
	}

	void OnTriggerEnter2D () {
		Destroy (gameObject);
	}
}
