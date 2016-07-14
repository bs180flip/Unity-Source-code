using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class boukennosho : MonoBehaviour {


	public AudioSource BGM;
	public AudioSource SE;

	// Use this for initialization
	void Start () {

		GameObject kakushi = GameObject.Find ("kakushi");
		Image Kakushi = kakushi.GetComponent<Image> ();
		Kakushi.enabled = true;

	}
		

	public void hajimeru(){

		GameObject kakushi = GameObject.Find ("kakushi");
		Image Kakushi = kakushi.GetComponent<Image> ();
		Kakushi.enabled = false;


	}
		

	public void bouken(){
		
	   GameObject camera =GameObject.Find ("Main Camera");
	   BGM =camera.gameObject.GetComponent<AudioSource> ();
	   BGM.Stop ();


		GameObject kesu =GameObject.Find ("kesu");
		SE =kesu.gameObject.GetComponent<AudioSource> ();
		SE.Play ();

		StartCoroutine("matsu");

	}


	public void Odenkun(){

		Application.LoadLevel ("Odenkun_Talk");

	}





	private IEnumerator matsu() {
		// ログ出力
		//Debug.Log ("1");

		// 1秒待つ
		yield return new WaitForSeconds (2.5f);

		BGM.Play();
	}


}
