using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class fead: MonoBehaviour {

	public int _frame = 0;

//	 Tatakau tatakau;

	// Use this for initialization
	void Start () {

		//参照渡しになっている
		//tatakau = GetComponent<Tatakau>();
	}

	void update(){

		//tatakau.tatakauButton ();
	    //if (tatakau.flag == 0) {
					Image Baramos = GetComponent<Image>();
					_frame++;
			
					//30フレーム毎に表示・非表示を繰り返す
					if (_frame / 10 % 2 == 0)
					{
						Baramos.enabled = false;
					}
					else
					{
						Baramos.enabled = true;
					}
						
				//}

	}

}

//	private int _frame = 0;
//
//	public Tatakau tatakau; 
//
//	void Start () {
//		tatakau = GetComponent<Tatakau>();
//	}
//
//	void Update () 
//	{
//		
//        tatakau.tatakauButton ();
//
//		if (tatakau.flag == 0) {
//		Image Baramos = GetComponent<Image>();
//		_frame++;
//
//		//30フレーム毎に表示・非表示を繰り返す
//		if (_frame / 10 % 2 == 0)
//		{
//			Baramos.enabled = false;
//		}
//		else
//		{
//			Baramos.enabled = true;
//		}
//			
//	}
//
//}
//
//}