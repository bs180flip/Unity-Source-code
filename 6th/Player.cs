using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	Animation animation;
	float speed = 0.08f;
	public AudioClip audioClip;
	public AudioClip jewelry;
	public AudioClip enemy_se;
	AudioSource audioSource;
	float sound_span =1.0f;
	GameObject obj;
	ScoreAdd score;
	GameObject gameobj;
	GameControl Damage;


	// Use this for initialization
	void Start () {

		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
	}

	
	// Update is called once per frame
	void FixedUpdate () {

		animation = this.transform.GetComponentInChildren<Animation> ();
		sound_span -=1.0f * Time.deltaTime;

		if (Input.GetKey ("up")) {
			// 上が押された！

			transform.position += new Vector3 (0, 0, speed);
			transform.eulerAngles = new Vector3 (0, 0, 0);
			animation.Play ("Take 001");
			//audio.PlayOneShot(m_stepSE,1.0f,0.0f);
			PlayStepSound();


		}

		if (Input.GetKey("down")) {
			// 上が押された！
			transform.position += new Vector3(0,0,-speed);
			transform.eulerAngles = new Vector3 (0, 180f, 0);
			animation.Play ("Take 001");
			PlayStepSound();
		}

		if (Input.GetKey("left")) {
			// 上が押された！
			transform.position += new Vector3(-speed,0,0);
			transform.eulerAngles = new Vector3 (0, -90.0f, 0);
			animation.Play ("Take 001");
			PlayStepSound();
		}

		if (Input.GetKey("right")) {
			// 上が押された！
			transform.position += new Vector3(speed,0,0);
			transform.eulerAngles = new Vector3 (0, 90.0f, 0);
			animation.Play ("Take 001");
			PlayStepSound();
		}

	
	}

	void PlayStepSound(){

		if(sound_span <= 0){
			audioSource.PlayOneShot (audioClip);
			sound_span = 0.5f; //タイマーを0.5秒に戻す
		}

	}

	void OnParticleCollision(GameObject objct){
		//処理内容
		//例）衝突したオブジェクトタグがダイヤだった場合、オブジェクトを破壊する

		if(objct.gameObject.tag == "jewelry"){
			Destroy(objct);
			Debug.Log ("test");
			audioSource.PlayOneShot (jewelry);
			obj = GameObject.Find ("Text");
			score = obj.GetComponent<ScoreAdd> ();
			score.score += 10;
		
		}
	}


	void OnTriggerEnter(Collider enemy){
		if(enemy.gameObject.tag == "enemy"){
			audioSource.PlayOneShot (enemy_se);
			gameobj = GameObject.Find ("GameControl");
			Damage = gameobj.GetComponent<GameControl> ();
			Damage.damage = true;

	}
		
}	
}