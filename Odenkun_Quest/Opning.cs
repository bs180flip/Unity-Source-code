using UnityEngine;
using System.Collections;

public class Opning : MonoBehaviour {

	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			//何らかの処理
//			audioSource = gameObject.GetComponent<AudioSource> ();
//
//			audioSource.Play ();

			Application.LoadLevel ("boukennosho");
     	}
	}
}
