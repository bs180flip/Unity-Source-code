using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class Opening : MonoBehaviour {

	GameObject goroumaru;
	GameObject yasumura;
//	GameObject Text;
	GameObject Push;
	private float x = 0.1f;
	private float y = 0.08f;

	// Use this for initialization
	void Start () {

		goroumaru = GameObject.Find ("goroumaru");
		yasumura = GameObject.Find ("yasumura");
//		Text = GameObject.Find ("Text");
		Push = GameObject.Find ("Push");

	
	}
	
	// Update is called once per frame
	void Update () {

		if(goroumaru.transform.position.x <= 1.5){
		goroumaru.transform.position += new Vector3(x,0,0);
		}

		if(yasumura.transform.position.x >= -1.8){
			yasumura.transform.position += new Vector3(-x,0,0);
		}

//		if(Text.transform.position.y >= 0.8){
//			Text.transform.position += new Vector3(0,-y,0);
//		}

		if(Push.transform.position.z >= -11.6f){
			Push.transform.position += new Vector3(0,0,-y);
		}

	}
}
