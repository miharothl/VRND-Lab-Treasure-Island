using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPicker : MonoBehaviour {

    public AudioClip[] audioClips;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {

        int index = Random.Range(0, audioClips.Length);

        audioSource.clip = audioClips[index];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
