using UnityEngine;
using System.Collections;

public class SendHitEventToParent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }


    void OnCollisionEnter(Collision col)
    {
       if(col.gameObject.tag != "RHand")
        {
            return;
        }
        var hand = transform.parent;
        if (hand.tag == "Hand")
        {
            CallCatch(hand);
            return;
        }

        hand = transform.parent.parent;
        if (hand.tag == "Hand")
        {
            CallCatch(hand);
         }
    }

    void CallCatch(Transform handTrans)
    {
        handTrans.GetComponent<catchHitEventFromChild>().CatchHitEvent();
    }



}
