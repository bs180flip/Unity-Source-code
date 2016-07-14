using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

		GameObject obj;
		Player_Controller pcon;
		public AudioClip hit = null;

		// Use this for initialization
		void Start () {
				obj = GameObject.FindWithTag ("Player");
				pcon = obj.GetComponent<Player_Controller>();
		}



		void OnTriggerStay(Collider collider) {

				if (collider.gameObject.tag == "New Tag") {

						if (pcon.flag == 1) {

								GetComponent<AudioSource> ().PlayOneShot (this.hit);
								collider.transform.position += new Vector3 (-2, 2, 0);
								pcon.speed += 0.05f;
								pcon.point += 1;
								pcon.point10 += 1;

						}
				}
		}


		void OnTriggerExit(Collider other) {

				pcon.flag = 0;
		}
}
