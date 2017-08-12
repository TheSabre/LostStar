using UnityEngine;
using System.Collections;

public class FloatingObj : MonoBehaviour {

	private bool inWater = false;
	public float buoyancy = 14.72f;
	private Vector3 force;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "water") {
			inWater = true;
			GetComponent<Rigidbody> ().drag = 5f;
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (col.tag == "water") {
			inWater = false;
			GetComponent<Rigidbody> ().drag = .05f;
		}
	}

	void FixedUpdate(){
		if (inWater) {
			force = (Vector3.up*buoyancy);
			GetComponent<Rigidbody> ().AddRelativeForce (force, ForceMode.Acceleration);
		}
	}
}
