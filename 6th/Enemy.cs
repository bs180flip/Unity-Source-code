using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public GameObject target;
	NavMeshAgent agent;
	private float jikan;
	// Use this for initialization
	void Start () {
		
		agent = GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {

		agent.destination = target.transform.position;
//		jikan += Time.deltaTime;
//
//		Debug.Log ("計算" + jikan);
//
//		if (jikan < 2) {
//			agent.destination = target.transform.position;
//		} else {
		//
//
//			StartCoroutine ("Stop_Enemy");
//		}
	
	}

	private IEnumerator Stop_Enemy(){
		yield return new WaitForSeconds (5.0f);
		jikan = 0;
//		gameObject.GetComponent<Rigidbody> ().isKinematic = true;

	}

}
