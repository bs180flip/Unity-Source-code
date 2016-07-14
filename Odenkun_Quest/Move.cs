using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// 移動スピード

	
	// Update is called once per frame
	void Update (){

		float speed = 0.8f;
		// 右・左
//		float x = Input.GetAxisRaw ("Horizontal");
//
//		// 上・下
//		float y = Input.GetAxisRaw ("Vertical");
//
//		// 移動する向きを求める
//		Vector2 direction = new Vector2 (x, y).normalized;
//
//		// 移動する向きとスピードを代入する
//		GetComponent<Rigidbody2D>().velocity = direction * speed;
		Vector2 Position = transform.position;

		//if (Input.GetKeyDown("up")) {

			if(Input.GetKey("up")){
			Position.y += speed;
			//transform.position += new Vector3 (0, 0, 0.1f);

		}


		if (Input.GetKey("down")) {
			Position.y -= speed;


		}

		if (Input.GetKey("right")) {
			Position.x += speed;


		}

		if (Input.GetKey("left")) {
			Position.x -= speed;

		}
		transform.position = Position;








		SceneChange ();
	}

	void SceneChange(){

	GameObject.Find("Odenroid");

		if (this.transform.position.x > 392 & this.transform.position.y > -117 ) {

			Debug.Log ("いちにたっしました");

			Application.LoadLevel("sentou");
		}
	}

}


