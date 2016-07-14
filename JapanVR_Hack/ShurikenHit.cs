using UnityEngine;
using System.Collections;

public class ShurikenHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Shuriken")
        {
            transform.parent.GetComponent<EnemyPopSystem>().hit();
        }
    }
}
