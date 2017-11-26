# Scripting a Simple Rotation

* Read: https://docs.unity3d.com/ScriptReference/Transform.Rotate.html
* Project: open ProgrammingAnimations scene
* Project: add script RotateLight
* RotateLight: update script
  * `public GameObject directionalLight;`
  * `void Update () {
 	 directionalLight.transform.Rotate (0f, Time.deltaTime, 0f);
    }`

* Sun: add script and wire up


# Scripting SLERP

* Read: https://en.wikipedia.org/wiki/Quaternion
* Read: https://docs.unity3d.com/ScriptReference/Quaternion.html
* Read: https://docs.unity3d.com/ScriptReference/Quaternion.Slerp.html
*
* RotateLight: update script
  * `void Update () {
       Quaternion startRotation = Quaternion.Euler (50f, 30f, 0f);
       Quaternion endRotation = startRotation * Quaternion.Euler(0f, 180f, 0f);
       directionalLight.transform.rotation = Quaternion.Slerp (startRotation, endRotation, Time.time / 10f);
     }`

# Scripting with Unity's Animator

* RotateLight: update script
  * `public Animator sunRotationAnimation;
     float startTime = 0f;
     bool isPressed = false; // Has the trigger button been pressed at least once?`
  * `start () {
       sunRotationAnimation.StartPlayback ();
     }`
  * `void Update () {
  
    if (Input.GetMouseButtonDown (0) && !isPressed) {
      // ...then update 'isPressed' to 'true'.
      isPressed = true;
    }
  
    if (isPressed) {
      // ...then rotate.
      sunRotationAnimation.StopPlayback ();
      sunRotationAnimation.SetBool ("ChangeColor", true);
    }`
