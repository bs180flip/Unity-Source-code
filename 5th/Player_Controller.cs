using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {

		public AudioClip attackleft = null;
		public AudioClip attackright = null;
		public AudioClip attackfinish = null;
		public AudioClip yarare = null;
		public AudioClip end = null;

		Animation animation;

		public float speed = 0.1f;
		public int flag = 0;
		public int anim_order = 0;
		public bool run = true;
		public bool damage = false;
		public int point;
		public int point10;
		public bool endaudio = true;
		[SerializeField]
		public Sprite[] sprite = new Sprite[10];

		GameObject obj;
		Scene_Controll scene;
	// Use this for initialization
	void Start () {

				obj = GameObject.FindWithTag ("Scene");
				scene = obj.GetComponent<Scene_Controll> ();
	}
	
	// Update is called once per frame
	void Update () {

				animation = this.transform.GetComponentInChildren<Animation> ();

				if (scene.end_flag == false) {

				if (!damage) {
						transform.position += new Vector3 (speed, 0, 0);
				} else {
						for (int i = 1; i < 5; i++) {
								transform.position -= new Vector3 (0.8f, 0, 0);
								speed = 0.1f;
						}
						damage = false;

				}

				} else if (scene.end_flag == true) {

						SpriteRenderer spriteRenderer;
						spriteRenderer = GetComponent<SpriteRenderer>();
						spriteRenderer.transform.localScale = new Vector3 (3, 3, 3);
						spriteRenderer.sprite = sprite [0];
						if (endaudio == true) {
								GetComponent<AudioSource> ().PlayOneShot (this.end);
								endaudio = false;
						}

				}
				if (run) {

						animation.Play ("P_run");

				}

				if(animation.IsPlaying("P_run")){
						flag = 0;
				}

				if (Input.GetMouseButtonDown (0)) {
						run = false;
						flag = 1;
						switch (anim_order) {

						case 0:
								animation.Play ("P_attack_L");
								GetComponent<AudioSource> ().PlayOneShot (this.attackleft);
								++anim_order;
								break;
						case 1:
								animation.Play ("P_attack_R");
								GetComponent<AudioSource> ().PlayOneShot (this.attackright);
								++anim_order;
								break;

						case 2:
								animation.Play ("P_attack_Rot_s");
								GetComponent<AudioSource> ().PlayOneShot (this.attackfinish);
								anim_order = 0;
								break;

						}


				}

				if (anim_order == 3) {
						run = false;
						damage = true;
						animation.Play ("P_yarare");
						GetComponent<AudioSource> ().PlayOneShot (this.yarare);
						anim_order = 0;

				}

		
				animation.CrossFadeQueued("P_run");
			
						

		}

}

