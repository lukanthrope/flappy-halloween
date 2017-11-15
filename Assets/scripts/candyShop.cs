using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class candyShop : MonoBehaviour {

	public Text candies;

	void Update () {
		candies.text = PlayerPrefs.GetInt ("candies").ToString ();
	}
}
