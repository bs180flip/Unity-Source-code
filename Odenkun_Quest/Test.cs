using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Test : MonoBehaviour 
{
	private int _frame = 0;

//	Tatakau tatakau;

	// Use this for initialization
	void Start ()
	{
	//	tatakau = GetComponent<Tatakau>();

	}

	// Update is called once per frame
	void Update () 
	{

	//	if (tatakau.tatakauButton() == 0) {

		_frame++;

		Image Baramos = GetComponent<Image> ();

		//30フレーム毎に表示・非表示を繰り返す
		if (_frame / 30 % 2 == 0)
		{
			Baramos.enabled = false;
		}
		else
		{
			Baramos.enabled = true;
		}
				
	}

}
//}