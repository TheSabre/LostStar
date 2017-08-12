using UnityEngine;
using System.Collections;

public class gravity_zero : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.collider.tag == "Player") {
			col.rigidbody.useGravity = false;
		}
	}
}
