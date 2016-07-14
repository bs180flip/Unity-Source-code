using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	private int score;

	void InitScore(){

		this.score = 0;
	}

	void AddScore(int score){

		this.score += score;
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<GUIText> ().text = "Score:" + this.score;
	
	}
}
