using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	public static Vector3 reachedPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			Controls.check = true;
			if (transform.position.x > reachedPoint.x)
				reachedPoint = transform.position;
		}
	}
}
