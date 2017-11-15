using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour {

	public GameObject[] suits;
	private int i;

	void OnMouseDown (){
		transform.localScale += new Vector3 (1f, 1f);
	}

	void OnMouseUp () {
		transform.localScale -= new Vector3 (1f, 1f);
	}

	void OnMouseUpAsButton () {
		switch (gameObject.name) {
		case "left":
			var pL0 = suits [0].transform.position;
			pL0.x += 4;
			suits [0].transform.position = pL0;

			var pL1 = suits [1].transform.position;
			pL1.x += 4;
			suits [1].transform.position = pL1;

			var pL2 = suits [2].transform.position;
			pL2.x += 4;
			suits [2].transform.position = pL2;

			var pL3 = suits [3].transform.position;
			pL3.x += 4;
			suits [3].transform.position = pL3;

			var pL4 = suits [4].transform.position;
			pL4.x += 4;
			suits [4].transform.position = pL4;

			var pL5 = suits [5].transform.position;
			pL5.x += 4;
			suits [5].transform.position = pL5;

			var pL6 = suits [6].transform.position;
			pL6.x += 4;
			suits [6].transform.position = pL6;

			var pL7 = suits [7].transform.position;
			pL7.x += 4;
			suits [7].transform.position = pL7;

			var pL8 = suits [8].transform.position;
			pL8.x += 4;
			suits [8].transform.position = pL8;

			var pL9 = suits [9].transform.position;
			pL9.x += 4;
			suits [9].transform.position = pL9;

			var pL10 = suits [10].transform.position;
			pL10.x += 4;
			suits [10].transform.position = pL10;

			var pL11 = suits [11].transform.position;
			pL11.x += 4;
			suits [11].transform.position = pL11;

			var pL12 = suits [12].transform.position;
			pL12.x += 4;
			suits [12].transform.position = pL12;

			break;
		case "right":
			var pR0 = suits [0].transform.position;
			pR0.x -= 4;
			suits [0].transform.position = pR0;

			var pR1 = suits [1].transform.position;
			pR1.x -= 4;
			suits [1].transform.position = pR1;

			var pR2 = suits [2].transform.position;
			pR2.x -= 4;
			suits [2].transform.position = pR2;

			var pR3 = suits [3].transform.position;
			pR3.x -= 4;
			suits [3].transform.position = pR3;

			var pR4 = suits [4].transform.position;
			pR4.x -= 4;
			suits [4].transform.position = pR4;

			var pR5 = suits [5].transform.position;
			pR5.x -= 4;
			suits [5].transform.position = pR5;

			var pR6 = suits [6].transform.position;
			pR6.x -= 4;
			suits [6].transform.position = pR6;

			var pR7 = suits [7].transform.position;
			pR7.x -= 4;
			suits [7].transform.position = pR7;

			var pR8 = suits [8].transform.position;
			pR8.x -= 4;
			suits [8].transform.position = pR8;

			var pR9 = suits [9].transform.position;
			pR9.x -= 4;
			suits [9].transform.position = pR9;

			var pR10 = suits [10].transform.position;
			pR10.x -= 4;
			suits [10].transform.position = pR10;

			var pR11 = suits [11].transform.position;
			pR11.x -= 4;
			suits [11].transform.position = pR11;

			var pR12 = suits [12].transform.position;
			pR12.x -= 4;
			suits [12].transform.position = pR12;

			break;
		}
	}
}
