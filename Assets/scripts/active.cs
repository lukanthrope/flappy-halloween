using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active : MonoBehaviour {

	public GameObject[] obj;

	void Start () {
		switch (PlayerPrefs.GetInt ("suit")) {
		case 1:
			obj [0].SetActive (true);
			break;
		case 2:
			obj [1].SetActive (true);
			break;
		case 3:
			obj [2].SetActive (true);
			break;
		case 4:
			obj [3].SetActive (true);
			break;
		case 5:
			obj [4].SetActive (true);
			break;
		case 6:
			obj [5].SetActive (true);
			break;
		case 7:
			obj [6].SetActive (true);
			break;
		case 8:
			obj [7].SetActive (true);
			break;
		case 9:
			obj [8].SetActive (true);
			break;
		case 10:
			obj [9].SetActive (true);
			break;
		case 11:
			obj [10].SetActive (true);
			break;
		case 12:
			obj [11].SetActive (true);
			break;
		case 13:
			obj [12].SetActive (true);
			break;
		default:
			obj [0].SetActive (true);
			break;
		}
	}
}
