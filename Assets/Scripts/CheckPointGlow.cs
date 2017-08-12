using UnityEngine;
using System.Collections;

public class CheckPointGlow : MonoBehaviour {

	public Light glow;
	public ParticleSystem burst;

	// Use this for initialization
	void Start () {
		glow.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			glow.enabled = true;

			ParticleSystem par = Instantiate (burst, this.transform.position,this.transform.rotation) as ParticleSystem;
	
			Destroy (par.gameObject,2f);

		}
	}
}
