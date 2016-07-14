using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public AudioClip audioClip1;
	public static AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip1;
		audioSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Ball.flag == 1) {
			iTween.MoveTo (gameObject, iTween.Hash ("x", -255f, "y", 10f, "z", -165f, "time", 4f, "isLocal", true));
			Ball.flag = 0;
			}
			

	}
}
