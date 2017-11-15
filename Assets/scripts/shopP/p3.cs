using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p3 : MonoBehaviour {

	public Text price, alert;
	private int thePrice = 25;

	void Start () {
		gameObject.tag = PlayerPrefs.GetString ("tagg3");
	}

	void Alert (string some) {
		alert.text = some;
	}

	void Alert1 () {
		alert.text = "";
	}

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

	void OnMouseUpAsButton () {
		int cand = PlayerPrefs.GetInt ("candies");

		if (gameObject.tag == "0") {
			PlayerPrefs.SetInt ("suit", 5);
			Application.LoadLevel ("main");
		} else {
			if (PlayerPrefs.GetInt ("candies") >= thePrice) {
				cand -= 25;
				PlayerPrefs.SetInt ("candies", cand);

				Alert ("B o u g h t !");
				Invoke ("Alert1", 1f);
				price.text = "";

				PlayerPrefs.SetString ("tagg3", "0");
				gameObject.tag = PlayerPrefs.GetString ("tagg3");
			} else {
				Alert ("N o t  e n o u g h  m o n e y");
				Invoke ("Alert1", 1f);
			}

		}
	}
}
