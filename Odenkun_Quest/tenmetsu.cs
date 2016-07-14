using UnityEngine;
using System.Collections;

public class tenmetsu : MonoBehaviour {
	private float nextTime;
	public float interval = 1.0f;	// 点滅周期

	Color alpha = new Color(0, 0, 0, 0.01f);

	// Use this for initialization
	void Start() {
		
	}

	// Update is called once per frame
		void Update () {
			if(GetComponent<Renderer>().material.color.a >= 0)
				GetComponent<Renderer>().material.color -= alpha;
		}
}
