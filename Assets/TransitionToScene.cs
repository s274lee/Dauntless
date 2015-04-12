//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
using Leap;

public class TransitionToScene : MonoBehaviour
{
	Controller controller;
	// Use this for initialization
	void Start () {
		controller = new Controller ();
		controller.EnableGesture (Gesture.GestureType.TYPESWIPE);
		// Setting Min Velocity and Length for the Swipe - change if feels forceful
		controller.Config.SetFloat ("Gesture.Swipe.MinLength", 50.0f);
		controller.Config.SetFloat ("Gesture.Swipe.MinVelocity", 350f);
		controller.Config.Save ();
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = controller.Frame ();
		GestureList gestures = frame.Gestures();
		for (int i = 0; i < gestures.Count; i++) {
			Gesture gesture = gestures[i];
			if(gesture.Type == Gesture.GestureType.TYPE_SWIPE) {
				SwipeGesture swipe = new SwipeGesture(gesture);
				Vector swipeDirection = swipe.Direction;
				if(swipeDirection.x < 0){
					Debug.Log ("Left");
					Application.LoadLevel ("menu1");
				} else if(swipeDirection.x > 0){
					Debug.Log ("right");
					Application.LoadLevel ("menu1");
				}
			}
		}
	}
//	void Update() {
//		if (Input.GetButton ("Jump")) {
//			Application.LoadLevel ("Dauntless_lightning");
//		}
//	}
}

