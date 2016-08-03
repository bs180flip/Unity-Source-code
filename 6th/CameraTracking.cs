using UnityEngine;
using System.Collections;

public class CameraTracking : MonoBehaviour {

	public Vector3 m_position;
	public Transform m_target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate  () {
		transform.position = m_target.position + m_position;

	}
}
