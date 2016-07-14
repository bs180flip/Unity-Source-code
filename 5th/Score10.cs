using UnityEngine;
using System.Collections;

public class Score10 : MonoBehaviour {

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

		void Update ()
		{
				spriteRenderer.sprite = sprite [pcon.point10/10];

		}

}


