using UnityEngine;
using System.Collections;

public class StopCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			GameObject.Find ("Camera").GetComponent<CameraFollow> ().target = null;
			GameObject.Find ("Camera (1)").GetComponent<CameraFollow> ().target = null;
		}
	}
}
