using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public GUITexture GameStart;
	public GUITexture StageClear;
	public GUITexture GameOver;
	GameObject obj;
	ScoreAdd score;
	AudioSource audioSource;
	public AudioClip audioClip;
	public AudioClip Gameover_se;
	bool clear = false;	
	public bool damage =false;


	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		GameStart.enabled = true;
		StageClear.enabled = false;
		GameOver.enabled = false;
		Time.timeScale = 0.0F;
	
	}
	
	// Update is called once per frame
	void Update () {
		obj = GameObject.Find ("Text");
		score = obj.GetComponent<ScoreAdd> ();

		if (Input.GetKey ("space")) {
			Time.timeScale = 1.0F;	
			GameStart.enabled = false;
		}

		if (score.score >= 100 && clear==false) {
			audioSource.PlayOneShot (audioClip);
			clear = true;
				Time.timeScale = 0.0F;
				StageClear.enabled = true;
		}
			
		if (damage==true){
		audioSource.PlayOneShot (Gameover_se);
		Time.timeScale = 0.0F;
			GameOver.enabled = true;
			damage=false;
	}
}

}
