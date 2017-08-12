using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

	public Collider deathPlt;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.collider.tag == "Player") {
			col.rigidbody.AddForce (Vector3.up * 2000);
			GameObject.Find ("Rover").GetComponent <Controls> ().dead = true;
			Invoke ("Disable", .1f);
		} else {
			deathPlt.enabled = false;
			Invoke ("Enable",1f);
		}
	}

	void Disable()
	{
		deathPlt.enabled = false;
		Invoke ("Enable", 2f);
	}

	void Enable()
	{
		deathPlt.enabled = true;
	}
}
