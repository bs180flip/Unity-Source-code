using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreAdd : MonoBehaviour {

	public int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Text> ().text = "Score:" + score.ToString ();
	
	}
}
