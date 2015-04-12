using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class rating : MonoBehaviour {

	public int score;
	Text text;


	// Use this for initialization
	void Start () {
		score = 1;
		text = GetComponent <Text> ();

	}

	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Vertical")) {
				  score = score + 1;
			}

			//if(Input.GetButton("down")) {
			//	  score = score - 1;
			//}
			text.text = "Your Rating Discomfort Scale: " + score;
	}
}
