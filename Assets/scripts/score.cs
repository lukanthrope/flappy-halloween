using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class score : MonoBehaviour {

	public Text s, hs, candies;

	void Start () {
		candies.text = PlayerPrefs.GetInt ("candies").ToString ();
		s.text = "Yo u r  s c o r e : " + PlayerPrefs.GetInt ("score").ToString ();
		hs.text = "H ig h t  s c o r e : " + PlayerPrefs.GetInt ("hs").ToString ();

		if (Advertisement.isSupported)
			Advertisement.Initialize ("1590683", false);

		if (Advertisement.IsReady () && PlayerPrefs.GetInt ("ad") % 3 == 0)
			Advertisement.Show ();
	}
}
