using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopPrice : MonoBehaviour {

	public Text price, alert;

	void OnTriggerEnter2D () {
		switch (gameObject.tag) {
		case "0":
			price.text = "";
			break;
		default:
			price.text = "B u y : 25";
			break;
		}
	}

	void OnMouseDown () {
		PlayerPrefs.SetInt ("suit", 1);
		Application.LoadLevel ("main");
	}
}
