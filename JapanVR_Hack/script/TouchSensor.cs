using UnityEngine;
using System.Collections;

public class TouchSensor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "RHand" || col.gameObject.tag == "LHand")
        {
            var obj = GameObject.Find("GameController");
            obj.GetComponent<GameStateMgr>().OnStart();
        }
    }
}
