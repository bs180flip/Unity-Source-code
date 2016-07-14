using UnityEngine;
using System.Collections;

public class oni : MonoBehaviour {

		public AudioClip oni_yarare = null;

		Animation animation;

		private float speed = 0.05f;
		public bool run = true;
		public bool oni_damage = false;
		GameObject obj;
		GameObject chara;
		Player_Controller pcon;

		// Use this for initialization
		void Start () {
				obj = GameObject.FindWithTag ("Player");
				chara = GameObject.FindWithTag ("Chara");
				pcon = obj.GetComponent<Player_Controller> ();

		}

		// Update is called once per frame
		void Update () {

				animation = this.transform.GetComponentInChildren<Animation> ();

				if (!oni_damage) {
						transform.position += new Vector3 (speed, 0, 0);
				}else{
						transform.position += new Vector3 (0, 0, 0);
				}
				oni_damage = false;


				if (run) {

						animation.Play ("oni_run1");

				}



		}


		void OnTriggerStay(Collider collider) {

				if (collider.gameObject.tag == "AttackCollider") {
						if (pcon.flag == 1) {
								animation.Play ("oni_yarare");
								StartCoroutine ("des");

						}

				}

		}

		private IEnumerator des() {
				GetComponent<AudioSource> ().PlayOneShot (this.oni_yarare);
				yield return new WaitForSeconds (1);
				Destroy (this.gameObject);
		}



}
