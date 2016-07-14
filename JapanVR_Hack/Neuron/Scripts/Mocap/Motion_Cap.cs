using UnityEngine;
using System.Collections;

public class Motion_Cap : MonoBehaviour {

	public string right_thum= "Robot_RightHandThumb1";
	public string right_index= "Robot_RightHandIndex1";
	private string right_middle= "Robot_RightHandMiddle1";

	public GameObject oya;
	public GameObject hito;
	public GameObject naka;
	public GameObject test;

	//スタート位置フラグ
	public int start_f;

	// Use this for initialization
	void Start () {
		oya = GameObject.Find (right_thum);
		hito = GameObject.Find (right_index);
		naka = GameObject.Find (right_middle);
	}

	// Update is called once per frame	
	void Update () {
		Vector3 vec = oya.transform.position;
		Quaternion qua = oya.transform.rotation;

		//if (Input.accelerationEventCount > 0)
		//	print("We got new acceleration measurements");

		if (vec.y >= 1.6f) {
			start_f = 1;
			//Debug.Log ("iti" + vec);

		}else{
			//Debug.Log("eeeeeeeeeeeeeeee");
		}
			
		if (start_f==1) {

			if(vec.y<=1.5f){
				Debug.Log("OK");
				start_f = 0;
			}
		}
		//Debug.Log ("kakudo" + qua);


//		Debug.Log ("oyayubi" + oya.transform.position);
//		Debug.Log ("hitosashi" + hito.transform.position);
//		Debug.Log ("nakayubi" + naka.transform.position);

	}
}
