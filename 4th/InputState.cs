using UnityEngine;
using System.Collections;

public class InputState : MonoBehaviour {
	
	public static float h;
	public static float v;
	public static bool isJump;
	public static bool isSliding;
	
	Joystick direction;
	Joystick jump;
	Joystick slide;
	bool mobile = false;
	
	void Start () {
		GameObject directionObject = GameObject.Find("Joystick");
		GameObject jumpObject = GameObject.Find("ButtonJump");
		GameObject slideObject = GameObject.Find("ButtonSliding");
		if (Application.platform == RuntimePlatform.IPhonePlayer
			|| Application.platform == RuntimePlatform.Android) {

			mobile =  true;
			direction = directionObject.GetComponent<Joystick>();
			jump = jumpObject.GetComponent<Joystick>();
			slide = slideObject.GetComponent<Joystick>();
		} else {
			directionObject.SetActive(false);
			jumpObject.SetActive(false);
			slideObject.SetActive(false);
		}
	}
	
	void Update () {
		h = Input.GetAxis("Horizontal");
		v = Input.GetAxis("Vertical");
		isJump = Input.GetKey(KeyCode.Space);
		isSliding = Input.GetKey(KeyCode.C);
		if (mobile) {
			h += direction.position.x;
			v += direction.position.y;
			isJump = isJump || jump.IsFingerDown();
			isSliding = isSliding || slide.IsFingerDown();
		}
	}
}
