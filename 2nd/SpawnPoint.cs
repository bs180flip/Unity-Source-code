using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {

	// 宇宙ゴミ プレハブ
	public GameObject Debri;
	// 宇宙ゴミ発生間隔
	public float interval = 1F;

	// 宇宙ゴミを発生中フラグ   
	private bool spawnStarted = false;

	//  宇宙ゴミ発生開始
	void StartSpawn () {
		if (!spawnStarted) {
			spawnStarted = true;
			StartCoroutine("SpawnDebris");
		}
	}

	//  宇宙ゴミ発生停止
	void StopSpawn () {
		if (spawnStarted) {
			spawnStarted = false;
			StopCoroutine("SpawnDebris");
		}
	}

	//  宇宙ゴミ発生
	IEnumerator SpawnDebris() {
		// 無限ループ
		while(true) {
			// 宇宙ゴミプレハブを SpawnPointオブジェクトの位置にインスタンス化する
			Instantiate(Debri, transform.position, Quaternion.identity);
			// interval 分だけ処理を停止する
			yield return new WaitForSeconds(interval);
		}
	}
}
