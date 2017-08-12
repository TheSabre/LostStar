using UnityEngine;
using System.Collections;

public class MotionBlurring : MonoBehaviour {

	public Component script;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			GameObject.Find("MainCamera").GetComponent< UnityStandardAssets.ImageEffects.CameraMotionBlur> ().enabled = true;
		}
	}
}
