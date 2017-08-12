using UnityEngine;
using System.Collections;

public class DeathPendulum : MonoBehaviour 
{
	private Rigidbody rb;
	private float t;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
			
		}


	void OnCollisionEnter(Collision col)
	{
		if (col.collider.tag == "Player") {
			col.rigidbody.maxAngularVelocity = 12;
			GameObject.Find ("Rover").GetComponent <Controls>().dead = true;
			Thrill.kill = true;
		}
	}
		
	
}