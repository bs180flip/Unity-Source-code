using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tatakau : MonoBehaviour {

	// int _frame = 0;

	public AudioSource audioSource;
	public AudioSource shouri;
	public AudioSource BGM;
	public AudioSource LVUP;

	public static int Baramos_Hp =1000;
	public int flag;

	void Start () {

	}

	public void tatakauButton(){
		

		if (Baramos_Hp > 100) {
			flag = 1;
			Debug.Log ("たたかうがおされました");
			GameObject.Find ("tatakau");
			audioSource = this.GetComponent<AudioSource> ();
			audioSource.Play ();

			Baramos_Hp -= 100;
			Debug.Log (Baramos_Hp); 
			StartCoroutine ("Tenmetsu");

		}else{

			GameObject camera =GameObject.Find ("Main Camera");
			BGM =camera.gameObject.GetComponent<AudioSource> ();
			BGM.Stop ();
	
		GameObject Hp =GameObject.Find ("Hp_State");
			shouri =Hp.gameObject.GetComponent<AudioSource> ();
			shouri.Play ();

			GameObject Bara = GameObject.Find ("Baramos Sprite");
			Image Baramos= Bara.GetComponent<Image>();
			Baramos.enabled = false;

			StartCoroutine ("taoshita");
		}
	}

	public void jyumonButton(){


		if (Baramos_Hp > 100) {
			flag = 1;
			Debug.Log ("じゅもんがおされました");
			GameObject.Find ("jyumon");
			audioSource = this.GetComponent<AudioSource> ();
			audioSource.Play ();

			Baramos_Hp -= 100;
			Debug.Log (Baramos_Hp); 
			StartCoroutine ("Tenmetsu");

		}else{

			GameObject camera =GameObject.Find ("Main Camera");
			BGM =camera.gameObject.GetComponent<AudioSource> ();
			BGM.Stop ();

			GameObject Hp =GameObject.Find ("Hp_State");
			shouri =Hp.gameObject.GetComponent<AudioSource> ();
			shouri.Play ();

			GameObject Bara = GameObject.Find ("Baramos Sprite");
			Image Baramos= Bara.GetComponent<Image>();
			Baramos.enabled = false;

			StartCoroutine ("taoshita");
		}
	}

			
	private IEnumerator taoshita() {
		// ログ出力
		//Debug.Log ("1");

		// 1秒待つ
		yield return new WaitForSeconds (2.0f);
		GameObject LV =GameObject.Find ("LVUP");
		LVUP = LV.gameObject.GetComponent<AudioSource> ();
		LVUP.Play ();

		// ログ出力
		//Debug.Log ("2");

		// 2秒待つ
		yield return new WaitForSeconds (3.0f);
		Application.LoadLevel ("Ending");

		// ログ出力
		//Debug.Log ("3");
	}

	private IEnumerator Tenmetsu() {

			GameObject Bara = GameObject.Find ("Baramos Sprite");
			Image Baramos = Bara.GetComponent<Image> ();

			yield return new WaitForSeconds (0.5f);

			for (int i = 0; i < 5; i++) {

				yield return new WaitForSeconds (0.1f);
				Baramos.enabled = false;

			
				yield return new WaitForSeconds (0.1f);
				Baramos.enabled = true;
			}

	}

	void Update () 
	{

//		_frame++;
//
//		if (Baramos_Hp > 101 & flag==1) {
//
//			GameObject Bara = GameObject.Find ("Baramos Sprite");
//			Image Baramos = Bara.GetComponent<Image> ();
//
//		//	for (_frame = 100; _frame < 10; _frame++) {
//				//30フレーム毎に表示・非表示を繰り返す
//			if (_frame / 30 % 2 == 0) {
//				Baramos.enabled = false;
//			} else {
//				Baramos.enabled = true;
//			}
//
//			//Debug.Log (_frame);
//			}
		}
}	




		