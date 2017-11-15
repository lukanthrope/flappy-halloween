using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class move : MonoBehaviour {

	private static int advCount = 0;
	public float speed = 2;
	public float force = 1;
	public Text t, txt, txt1;
	private int score = 0;
	private int candies = 0;
	public GameObject sw, beep;

	void Awake () {
		GetComponent<Rigidbody2D> ().simulated = false;
	}

	void Start () {
		Invoke ("Text1", 1.5f);
		Invoke ("Text2", 3.1f);
		Invoke ("Down", 3f);
		Invoke ("Down2", 4f);
		Invoke ("Down2", 5f);
	}

	void Text1 () {
		t.text = "G O !";
	}

	void Text2 () {
		Destroy(t);
	}

	void Down () {
		GetComponent<Rigidbody2D> ().simulated = true;
		GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
	}

	void Down2 () {
		speed += 2;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * force);
			if (PlayerPrefs.GetString ("sound") != "no") 
				sw.GetComponent <AudioSource> ().Play ();
		}
	}

	void OnCollisionEnter2D (Collision2D coll) {
		if (PlayerPrefs.GetString ("sound") != "no")
			GetComponent <AudioSource> ().Play ();

		PlayerPrefs.SetInt ("score", score);
		int c = PlayerPrefs.GetInt ("candies") + candies;
		PlayerPrefs.SetInt ("candies", c);

		if (PlayerPrefs.GetInt ("hs") < score)
			PlayerPrefs.SetInt ("hs", score);

		advCount++;
		PlayerPrefs.SetInt ("ad", advCount);

		Invoke ("Lose", 0.2f);
	}

	void Lose () {
		Application.LoadLevel("lose");
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag != "candy") {
			score++;
			txt.text = score.ToString ();
		} else {
			if (PlayerPrefs.GetString ("sound") != "no")
				beep.GetComponent<AudioSource> ().Play (); 
			candies++;
			txt1.text = candies.ToString ();
		}
	}
}