using UnityEngine;
using System.Collections;

public class FallingStone : MonoBehaviour {

	Rigidbody rg;

	// Use this for initialization
	void Start () {
		rg = GetComponentInChildren<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			rg.useGravity = enabled;
		}
	}
}
