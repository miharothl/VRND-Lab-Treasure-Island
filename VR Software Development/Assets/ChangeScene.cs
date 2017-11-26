using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GoToScene(string sceneName) {
		Debug.Log ("GoToScene was called");
		SceneManager.LoadScene (sceneName);
	}
}
