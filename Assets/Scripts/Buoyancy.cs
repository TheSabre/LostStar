using UnityEngine;
using System.Collections;

public class Buoyancy : MonoBehaviour {

	public static bool inWater;
	public float buoyancy = 14.72f;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			inWater = true;
			col.attachedRigidbody.drag = 5f;
			rb = col.attachedRigidbody;
		}
			
	}

	void OnTriggerExit(Collider col)
	{
		if (col.tag == "Player") {
			inWater = false;
			col.attachedRigidbody.drag = 0.05f;
		}
	}

	void FixedUpdate()
	{
		if (inWater) {
			Vector3 force = (Vector3.up * buoyancy);
			if (rb != null) {
				rb.AddRelativeForce (force,ForceMode.Acceleration);
			}
		}
	}
}
