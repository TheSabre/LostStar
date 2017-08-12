using UnityEngine;
using System.Collections;

public class Torque : MonoBehaviour {
	Rigidbody rb;
	public static bool roll;
	private Vector3 pos; 
	private int count = 0;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.maxAngularVelocity = 10f;
		pos = transform.position;
		GetComponent<Rigidbody> ().useGravity = false;
		roll = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (roll) {
			GetComponent<Rigidbody> ().AddTorque (Vector3.back*40f);
			GetComponent<Rigidbody> ().useGravity = true;
		}
	}
		
	void OnCollisionEnter(Collision col)
	{
		if (col.collider.tag == "Player") {
			count++;
			Debug.Log ("Collided");
			col.rigidbody.maxAngularVelocity = 20f;
			GameObject.Find ("Rover").GetComponent <Controls> ().dead = true;
			if (count == 1) {
				Invoke ("Revoke", 0f);
			}
			Destroy (this.gameObject,4f);

		}
	}

	void Revoke(){
		roll = false;
		count = 0;
		Instantiate (this.gameObject, pos, transform.rotation);
	}

}
