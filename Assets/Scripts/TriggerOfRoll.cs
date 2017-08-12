using UnityEngine;
using System.Collections;

public class TriggerOfRoll : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			Torque.roll = true;
			GameObject.Find ("Rover").GetComponent<Controls> ().nearCam.enabled = false;
			GameObject.Find("Rover").GetComponent<Controls>().farCam.enabled = true;
			col.attachedRigidbody.maxAngularVelocity = 30;
		}
	}
}
