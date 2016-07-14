using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 


public class Title: MonoBehaviour {

	public AudioSource audiosource;
	public AudioClip audioclip1;

	void Start () {

	}

	void Update () {

		//if (Input.GetKey ("space")) {

		if(Input.GetKeyDown(KeyCode.Space)){

			int i =0 ;

			if (i == 0) {
				audiosource = GetComponent<AudioSource> ();
				audiosource.clip = audioclip1;
			
				audiosource.PlayOneShot (audioclip1);
				i = 1;
				Invoke ("change", 1f);

			}

		}

		}

	void change(){
		SceneManager.LoadScene("ragby2");
	}
}