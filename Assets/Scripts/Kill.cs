using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.collider.tag == "Player") {
			GameObject.Find ("Rover").GetComponent<Controls> ().dead = true;
		}
	}
}
