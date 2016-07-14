using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class SpriteControll : MonoBehaviour {

	private SpriteRenderer spriterend;
	public AudioSource audiosource;
	public AudioClip audioclip;
	public float a;

	// Use this for initialization
	void Start () {

		audiosource = gameObject.GetComponent<AudioSource> ();

		spriterend = GetComponent<SpriteRenderer> ();

		 a = 0f;
		StartCoroutine ("alfa");

	}
	
	// Update is called once per frame
	void Update () {

	
		spriterend.color = new Color (255, 255, 255, a);
		a += 0.003f;

	
	}

	IEnumerator alfa(){

		yield  return new WaitForSeconds (1.0f);
		audiosource.clip = audioclip;
		audiosource.PlayOneShot (audioclip);

		yield  return new WaitForSeconds (5.0f);
		SceneManager.LoadScene ("Title");

	
	}



}
