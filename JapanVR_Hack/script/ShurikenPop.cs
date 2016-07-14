using UnityEngine;
using System.Collections;

public class ShurikenPop : MonoBehaviour {

    public GameObject ShurikenObj;
    public Transform popTrans;

    [SerializeField,HeaderAttribute("射出力")]
    public float power;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void PopShuriken(Vector3 dir)
    {

        var ins =
            Instantiate
            (ShurikenObj, popTrans.position, Quaternion.identity) as GameObject;

        var rig = ins.GetComponent<Rigidbody>();
        rig.AddForce(dir * power, ForceMode.Impulse);

        //Debug.Break();
    }
}
