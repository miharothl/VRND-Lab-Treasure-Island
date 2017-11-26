Basic UI in Unity

* Scene: add Canvas
* Canvas: add Text
* Text: adjust text
   * allignement, horizontal, vertical central
   * reset position
* Canvas: Change canvas render modes to world space
* Canvas: set width and hight to 300
* Canvas: scale canvas to 2%
* Canvas: change dynamic pixels per pixel to 6, so its not blurry
* Canvas: rotate to the floor
* Text: set text: Click here to go on vacation
* Text: set vertical overflow to: overflow
*

Event System and Inputs

* Scene: add GvrEventSystem
* Vacation Box: add Box Collider
* Vacation Box: add Event Trigger

Methods and Debugging

* Vacation Box: add ChangeScene script
* ChangeScene: add method 
    ` public void GoToScene() { Debug.Log("GoToScene was called"); }`

Scene Changing via Script

* Unity > File > Build Settings: Add scenese
    * 01-TakeAVacation
    * 00-FallingCoconut
* ChangeScene: update method
    ` public void GoToScene() {
    	 Debug.Log("GoToScene was called");
	 SceneManager.LoadScene("00-FallingCoconut");
	 }`

The power of Variables
* ChangeScene: update method
    ` public void GoToScene(string sceneName) {
    	 Debug.Log("GoToScene was called");
	 SceneManager.LoadScene(sceneName);
	 }`
* Vacation Box: Rewire Event Triggrer, set scene name "00-FallingCoconut"





