using UnityEngine;
using System.Collections;

public class NextMenu : MonoBehaviour {

	// Update is called once per frame
	void Update () {
	    if(Input.GetButton("Jump")) {
				  Application.LoadLevel("menu2");
			}
	}
}
