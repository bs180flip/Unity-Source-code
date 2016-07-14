using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Vector3 pos;
	public static int flag;
	public static bool bo;
	private int vect;
	public AudioClip audioClip1;
	public AudioClip audioClip2;
	public AudioClip audioClip3;
	private AudioSource audioSource;
	public GameObject Goal;
	public GameObject yasumurakeeper;
	public GameController gamecontroller;
	public GameObject Boom;


	void Start () {
		
		flag = 0;
		bo = false;
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip = audioClip1;
		gamecontroller = GameObject.Find("GameController").GetComponent<GameController> ();


	}

	void Update () {

		if (flag == 1) {

			transform.Rotate (pos * Time.deltaTime);
		}
		if (Input.GetKey ("up")) {
			vect = 1;
		}
		if (Input.GetKey ("down")) {
			vect = 2;
		}

//		if (Input.GetKey ("up") || Input.GetKey ("down")) {
//
//			Instantiate (yasumurakeeper);
//		}

		if (transform.position.x < -270 && !bo) {

			CameraController.audioSource.Stop ();
			audioSource.PlayOneShot (audioClip3);
			//audioSource.volume = 0.8f;
			audioSource.PlayOneShot (audioClip2);
			Instantiate(Goal);
			bo = true;
			gamecontroller.pointadd ();
			gamecontroller.countadd ();
			gamecontroller.SceneCheck ();
		}
			

	}

	void OnTriggerEnter(Collider col){



		if (col.gameObject.tag != "yasumura") {
			
			audioSource.PlayOneShot (audioClip1);
		//	Boom.transform.position = new Vector3(-257,0.281,-169.22
			Instantiate(Boom,transform.position,Quaternion.identity);
		

		} else {
			Destroy (gameObject);
		}
			

		if (vect == 1) {
			iTween.MoveTo (gameObject, iTween.Hash ("x", -300f, "y", 40f, "z", -165f, "time", 30f, "isLocal", true));
		}

		if (vect == 2) {
			iTween.MoveTo (gameObject, iTween.Hash ("x", -300f, "y", 40f, "z", -140f, "time", 30f, "isLocal", true));
		}
		flag = 1;
	}
		

}