using UnityEngine;
using System.Collections;

public class RightHandWatcher : MonoBehaviour {

    /// <summary>
    /// 監視対象
    /// </summary>
    public Transform Target;

    /// <summary>
    /// 監視時間：経過後手裏剣をポップ
    /// </summary>
    public float watchTime;

    ShurikenPop sPop;
    bool once = false;

	// Use this for initialization
	void Start () {
        sPop = gameObject.GetComponent<ShurikenPop>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnWatch()
    {
        if(once)
        {
            return;
        }
        once = true;
        StartCoroutine("watch");        
    }

    IEnumerator watch()
    {
        var bigenPos = Target.position;

        yield return new WaitForSeconds(watchTime);

        var direction = Target.position - bigenPos;
        //Debug.Log(direction);
        sPop.PopShuriken(direction.normalized);

        once = false;
        yield break;
    }
}
