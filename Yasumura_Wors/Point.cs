using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Point: MonoBehaviour {
	public Text guitext;
	public Text text;
	public Text ten;
	public int endpoint;
	public int count;
	public GameObject Tokuten;
	public GameObject Win;
	public GameObject Lose;
	public AudioClip audioClip1;
	public AudioClip audioClip2;
	public AudioClip audioClip3;
	public AudioClip audioClip4;
	public AudioClip audioClip5;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource> ();
		StartCoroutine ("Sample1");

	}
		
	IEnumerator Sample1() {
		yield return new WaitForSeconds (2.0f);

		Instantiate (Tokuten);

		text = GameObject.Find ("Text").GetComponent<Text> ();
		guitext = GameObject.Find("point").GetComponent<Text> ();
		ten = GameObject.Find("ten").GetComponent<Text> ();
		endpoint = GameController.point;
		count = GameController.count;

		guitext.text = endpoint.ToString ();
		//endpoint = 6;

		Debug.Log ("カウントアップスタート");

		if (endpoint > 0) {

				for (int i = 1; i <= 3; i++) {

					guitext.text = i.ToString ();

					audioSource.clip = audioClip1;
					audioSource.PlayOneShot (audioClip1);

					// 3秒待つ
					yield return new WaitForSeconds (2.0f);
				}
				

				if (endpoint > 3) {

					for (int i = 4; i <= endpoint; i++) {

						guitext.text = i.ToString ();

					audioSource.clip = audioClip2;
					audioSource.PlayOneShot (audioClip2);

						// 3秒待つ
						yield return new WaitForSeconds (2.0f);
					}

				    guitext.enabled = false;
				    text.enabled = false;
				    ten.enabled = false;
					Instantiate (Win);
					audioSource.clip = audioClip3;
					audioSource.PlayOneShot (audioClip3);
					
				}

			if (endpoint < 4) {
				guitext.enabled = false;
				text.enabled = false;
				ten.enabled = false;
				Instantiate (Lose);
				audioSource.clip = audioClip4;
				audioSource.PlayOneShot (audioClip4);
			}

		} else {
			guitext.text = "0";
			StartCoroutine ("Sample2");
			guitext.enabled = false;
			text.enabled = false;
			ten.enabled = false;
			Instantiate (Lose);
			audioSource.clip = audioClip4;
			audioSource.PlayOneShot (audioClip4);
		}
}




	IEnumerator Sample2() {

		yield return new WaitForSeconds (2.0f);
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Space)){

			audioSource = GetComponent<AudioSource> ();
			audioSource.clip = audioClip5;

			audioSource.PlayOneShot (audioClip5);

			Invoke ("change", 1f);
		}
	}

	void change(){
		GameController.init ();
		SceneManager.LoadScene("Title");
	}
		
}