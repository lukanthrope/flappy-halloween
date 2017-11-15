using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour {

	public Sprite blue, red;
	public GameObject yes, no, music;

	void Start () {
		if (gameObject.name == "sound") {
			if (PlayerPrefs.GetString ("sound") == "no") {
				yes.SetActive (false);
				no.SetActive (true);
				music.SetActive (false);
			} else {
				yes.SetActive (true);
				no.SetActive (false);
				music.SetActive (true);
			}
		}
	}

	void OnMouseDown (){
		GetComponent <SpriteRenderer> ().sprite = red;
	}

	void OnMouseUp () {
		GetComponent <SpriteRenderer> ().sprite = blue;
	}

	void OnMouseUpAsButton () {
		switch (gameObject.name) {
		case "play":
			Application.LoadLevel ("play");
			break;

		case "out":
			Application.LoadLevel ("main");
			break;

		case "char":
			Application.LoadLevel ("shop");
			break;
		case "sound": 
			if (PlayerPrefs.GetString ("sound") != "no") {
				PlayerPrefs.SetString ("sound", "no");
				yes.SetActive (false);
				no.SetActive (true);
				music.SetActive (false);
			} else {
				PlayerPrefs.SetString ("sound", "yes");
				no.SetActive (false);
				yes.SetActive (true);
				music.SetActive (true);
			}
			break;
		}
		
	}

}
