using UnityEngine;
using System.Collections;

public class BreakableWall : MonoBehaviour {

	public ParticleSystem magic;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.collider.tag == "Player") {
			ParticleSystem particle = Instantiate (magic, transform.position,magic.transform.rotation) as ParticleSystem;
			Destroy (gameObject,2f);
		}
	}
}
