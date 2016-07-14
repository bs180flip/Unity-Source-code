using UnityEngine;
using System.Collections;

public class AnimationController: MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		animator.speed = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 Position = transform.position;

		if (Input.GetKey("up")) {

			animator.SetInteger ("houkou", 1);

//			animator.SetBool ("vector", true);
//			animator.SetBool ("right", false);

		}


		if (Input.GetKey("down")) {

			animator.SetInteger ("houkou", 0);



//			animator.SetBool ("vector", false);
//			animator.SetBool ("right", false);
		}

		if (Input.GetKey("right")) {

			animator.SetInteger ("houkou", 2);


			//animator.SetBool ("right", true);
		}

		if (Input.GetKey("left")) {

			animator.SetInteger ("houkou", 3);


			//animator.SetBool ("right", true);
		}
			
		//transform.position = Position;

			
	
	}
}
	