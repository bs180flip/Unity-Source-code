using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class Yasumura_Controller : MonoBehaviour {

	Animator animator;
	static float v;
	public AudioClip audioClip1;
	public AudioClip audioClip2;
	public AudioClip audioClip3;
	private AudioSource audioSource;
	public GameObject yasumuraPrefab;
	public GameController gamecontroller;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		gamecontroller = GameObject.Find("GameController").GetComponent<GameController> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("up") || Input.GetKey ("down") ) {

			Invoke ("trans", 2.3f);
			Invoke ("anim",2.7f);
			animator.SetBool ("Bool", false);

		} 
	}

	void OnTriggerEnter(Collider col){
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip1;
		audioSource.PlayOneShot (audioClip1);
		gamecontroller.countadd ();
		Invoke ("des", 2);

	}

	void anim(){

		animator.SetBool ("Bool", true);

		int x = Random.Range (0, 10);

		if (x >= 6) {
			transform.position += new Vector3 (0, 0, 0.1f);
		} else {
			transform.position += new Vector3 (0, 0, 1f);
		}
			
	}

	void des(){
		CameraController.audioSource.Stop ();
		transform.position =new Vector3(1000, 1000, 1000);
		Instantiate(yasumuraPrefab);
		audioSource.clip = audioClip2;
		audioSource.Play ();
		gamecontroller.SceneCheck ();
	}
		
	void trans(){
		transform.position = new Vector3 (-269,7.5f,-172);
	}
		

}
