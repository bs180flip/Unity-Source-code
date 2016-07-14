using UnityEngine;
using System.Collections;

public class Score1 : MonoBehaviour {

		GameObject obj;
		Player_Controller pcon;

		SpriteRenderer spriteRenderer;


		[SerializeField]
		public Sprite[] sprite = new Sprite[10];

		void Start () {

				obj = GameObject.FindWithTag ("Player");
				pcon = obj.GetComponent<Player_Controller> ();
				spriteRenderer = GetComponent<SpriteRenderer>();
				spriteRenderer.sprite = sprite[0];

		}

		void Update(){
				if (pcon.point < 10) {
						spriteRenderer.sprite = sprite [pcon.point];
				} else if (pcon.point == 10) {
						pcon.point = 0;
						spriteRenderer.sprite = sprite [pcon.point];
				}
		}
}
