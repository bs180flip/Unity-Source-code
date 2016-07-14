using UnityEngine;
using System.Collections;
using UnityEngine.Sprites;

public class Sprite_Make : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		for(int i = 0; i < 5; i++){
		SpriteMake ();
		}

//		for (int i = 0; i < array.Length; i++)
//		{
//			Debug.Log(array[i]);
//		}




	}


	void SpriteMake(){
		if (Input.GetKey (KeyCode.Space)) {
			//何らかの処理

			//Sprite spriteImage = Resources.Load<Sprite> ("town");
			Sprite spriteImage = Resources.Load("town", typeof(Sprite)) as Sprite;
			new GameObject ("Sprite").AddComponent<SpriteRenderer> ().sprite = spriteImage;
		
			//= spriteImage;
			//Vector3 position = transform.position + (new Vector3(0, 0,0));

		}
	}




}

