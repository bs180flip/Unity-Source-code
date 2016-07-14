using UnityEngine;
using System.Collections;

public class Scene_Controll : MonoBehaviour {

		public GameObject enemy;
		GameObject obj;
		GameObject chara;
		float LimitTime = 30;
		public bool end_flag = false;

		// Use this for initialization
		void Start () {

				chara = GameObject.FindWithTag ("Chara");
				StartCoroutine ("entry");

		}

		// Update is called once per frame
		void Update () {

				LimitTime -= Time.deltaTime;

				if (LimitTime < 0) {
						end_flag = true;
				}


				//Debug.Log ("Time" + LimitTime);


		}


		private IEnumerator entry() {

				Vector3 pos1 = chara.transform.position;
				pos1.x += 5;

				obj = Instantiate (enemy);
				obj.transform.position = pos1;


				while(LimitTime > 0){
						int x = Random.Range (1,3);  
						yield return new WaitForSeconds (x);
						Vector3 pos2 = chara.transform.position;
						pos2.x += 20;
						obj = Instantiate (enemy);
						obj.transform.position = pos2;
				}

		}


}


