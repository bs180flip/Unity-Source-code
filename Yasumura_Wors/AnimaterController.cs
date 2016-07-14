using UnityEngine;
using System.Collections;

public class AnimaterController : MonoBehaviour {

	Animator animator;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

//		float v = Input.GetAxis("Vertical");
//		float h = Input.GetAxis ("Horizontal");
		if (Input.GetKey ("up") ||Input.GetKey ("down") ) {


			//		if (Input.GetAxis ("Vertical")) {
			animator.SetBool ("Bool", true);
		} 
		//animator.SetBool ("Bool", false);
	
	}
}
