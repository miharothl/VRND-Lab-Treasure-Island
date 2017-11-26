using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour {

	public GameObject directionalLight;

	public Animator sunRotationAnimation;

	float startTime = 0f;
	bool isPressed = false; // Has the trigger button been pressed at least once?

	// Use this for initialization
	void Start () {
	  sunRotationAnimation.StartPlayback ();
	}
	
	// Update is called once per frame
	void Update () {
		// basic
		// directionalLight.transform.Rotate (0f, Time.deltaTime, 0f);

		// using SLERP
		//Quaternion startRotation = Quaternion.Euler (50f, 30f, 0f);              
		//Quaternion endRotation = startRotation * Quaternion.Euler(0f, 180f, 0f); 
		//directionalLight.transform.rotation = Quaternion.Slerp (startRotation, endRotation, Time.time / 100f);

		// If the player pressed the cardboard button (or touched the screen) AND it has not already been pressed...
		if (Input.GetMouseButtonDown (0) && !isPressed) {
			// ...then update 'isPressed' to 'true'.
			isPressed = true;
		}

		// If the player pressed the cardboard button (or touched the screen) at least once...
		if (isPressed) {
			// ...then rotate.
			sunRotationAnimation.StopPlayback ();
			sunRotationAnimation.SetBool ("ChangeColor", true);
		}
	}
}
