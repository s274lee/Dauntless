using UnityEngine;
using System.Collections;

public class NextMenu2 : MonoBehaviour {

	// Use this for initialization
	void Update () {
			if(Input.GetButton("Jump")) {
					Application.LoadLevel("Dauntless_lightning");
			}
	}
}
