using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {

	public AudioSource audioSource;

	// Use this for initialization
	void Start () {



	}

	// Update is called once per frame
	void Update () {

		audioSource = gameObject.GetComponent<AudioSource> ();
		if (Input.GetMouseButtonDown (0)) {
			//何らかの処理
			audioSource.Play ();
		}
		if (Input.GetMouseButtonDown (1)) {
			//何らかの処理
			audioSource.Stop ();
		}
	}
}
