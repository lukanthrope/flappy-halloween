using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tombMove : MonoBehaviour {

	public float speed = 0.1f;

	void FixedUpdate () {
		transform.Translate (Vector2.left * speed * Time.deltaTime);
	}

	void Start () {
		Invoke ("Destr", 20);
	}

	void Destr () {
		Destroy (gameObject);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		GetComponent <AudioSource> ().Play ();
	}
}
