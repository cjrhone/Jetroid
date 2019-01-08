using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject target; 
	public float scale = 4f;
	//adjusted for small sprites

	private Transform t;

	// Use this for initialization

	void Awake() {
		var cam = GetComponent<Camera>();
		cam.orthographicSize = (Screen.height / 2f) / scale;
		
	}
	void Start () {

		t = target.transform;
		// assumes that the target is chosen when the script is initialized
		
	}
	
	// Update is called once per frame
	void Update () {
		if(target != null) {
			transform.position = new Vector3(t.position.x, t.position.y, transform.position.z);
			// cameras position updating with targets position
		}
		
	}
}
