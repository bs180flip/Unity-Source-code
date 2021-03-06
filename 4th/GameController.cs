using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	public GameObject player;
	public Transform spawnPoint;
		
	SmoothFollow smoothFollow;
	SoundEffect soundEffect;
	
	void Start() {
		smoothFollow = GameObject.Find("Main Camera").GetComponent<SmoothFollow>();
		soundEffect = GameObject.Find("SoundController").GetComponent<SoundEffect>();
		SpawnPlayer();
	}
	
	void SpawnPlayer() {
		GameObject playerClone = (GameObject) Instantiate(player, spawnPoint.position, spawnPoint.rotation);
		smoothFollow.target = playerClone.transform;
	}
	
	void TrapHit() {
		soundEffect.PlayScream();
		SpawnPlayer();
	}
	
	void TreasureHit() {
		soundEffect.PlayClear();
		StartCoroutine("RestartScene");
	}
	
	IEnumerator RestartScene() {
		yield return new WaitForSeconds(2);
		Application.LoadLevel(0);
	}
}
