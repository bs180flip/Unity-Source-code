using UnityEngine;
using System.Collections;

public class BGM : MonoBehaviour {

	public AudioClip button;
	public AudioClip bomb;
	private AudioSource audioSouce;


	public void button_wav(){

		audioSouce = gameObject.GetComponent<AudioSource> ();
		audioSouce.clip = button;
		audioSouce.Play ();

	}

	public void bomb_wav(){

		audioSouce = gameObject.GetComponent<AudioSource> ();
		audioSouce.clip = bomb;
		audioSouce.Play ();

	}
		
}
