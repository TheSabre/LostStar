using UnityEngine;
using System.Collections;

public class ZoomOut : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			GameObject.Find ("Rover").GetComponent<Controls> ().nearCam.enabled = false;
			GameObject.Find ("Rover").GetComponent<Controls> ().farCam.enabled = true;
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (col.tag == "Player") {
			GameObject.Find ("Rover").GetComponent<Controls> ().nearCam.enabled = true;
			GameObject.Find ("Rover").GetComponent<Controls> ().farCam.enabled = false;
		}
	}

}
