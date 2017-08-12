using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour {

	public Canvas canvas;

	// Use this for initialization
	void Start () {
		canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{
		col.rigidbody.useGravity = false;
		Invoke ("End", 5f);
	}

	void End()
	{
		canvas.enabled = true;
	}
}
