using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theLine : MonoBehaviour {

	public GameObject left, right;

	void OnTriggerEnter2D () {
		if (gameObject.name == "if_jack_202896")
			left.GetComponent<BoxCollider2D> ().enabled = false;
		else 
			right.GetComponent<BoxCollider2D> ().enabled = false;
	}

	void OnTriggerExit2D () {
		if (gameObject.name == "if_jack_202896")
			left.GetComponent<BoxCollider2D> ().enabled = true;
		else
			right.GetComponent<BoxCollider2D> ().enabled = true;
	}
}
