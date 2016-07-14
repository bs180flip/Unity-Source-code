using UnityEngine;
using System.Collections;
using UnityEngine.VR;

/// <summary>
/// Rでポジトラリセット
/// </summary>
public class RePotionHMD : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.R))
        {
            InputTracking.Recenter();
        }
	}
}
