using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameController : MonoBehaviour {
	public static int point;
	public static int count;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
		
	public void pointadd(){

			point += 1;

		Debug.Log ("Point:" + point);
		Debug.Log ("Count:" + count);
	}

	public void countadd(){
		count += 1;

		Debug.Log ("Count:" + count);

	}


	public void SceneCheck(){
		StartCoroutine ("Sample1");

		}

	IEnumerator Sample1() {
		Debug.Log ("3秒待つ");

		// 3秒待つ
		yield return new WaitForSeconds (3.0f);

		if (count > 5) {
			count = 0;
			SceneManager.LoadScene ("Tokuten");
		} else {
			SceneManager.LoadScene ("ragby2");
		}	
	
	}

 public	static void init(){
		point = 0;
		Debug.Log (point);

	}
		

}