using UnityEngine;
using System.Collections;

public class PlayAudio : MonoBehaviour {

    public AudioSource audioSorse;

	// Use this for initialization
	void Start () {
        audioSorse = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Play()
    {
        audioSorse.Play();
    }
}
