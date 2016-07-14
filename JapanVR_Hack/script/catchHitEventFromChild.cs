using UnityEngine;
using System.Collections;

public class catchHitEventFromChild : MonoBehaviour {

    RightHandWatcher watch = null;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CatchHitEvent()
    {
        //Debug.Log("Hit");
        if(watch)
        {
            watch.OnWatch();
            return;
        }

        watch = GetComponent<RightHandWatcher>();
        watch.OnWatch();

    }
}
