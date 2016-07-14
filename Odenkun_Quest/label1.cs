using UnityEngine;
using System.Collections;

public class label1 : MonoBehaviour {

	void OnGUI() {
		GUI.Label (new Rect (300, 300, 200,100), "Hello World!");
	}
}

