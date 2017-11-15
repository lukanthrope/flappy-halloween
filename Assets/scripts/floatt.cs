using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatt : MonoBehaviour {

	void Update () {
		transform.position = new Vector3(transform.position.x, 0.5f + Mathf.Sin(Time.fixedTime) * 1.2f, transform.position.z);
	}
}