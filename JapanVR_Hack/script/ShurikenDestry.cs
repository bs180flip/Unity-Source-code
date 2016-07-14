using UnityEngine;
using System.Collections;

public class ShurikenDestry : MonoBehaviour {

    public float lifeTime = 5.0f;
	// Use this for initialization
	void Start () {
        Destroy(this, lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
