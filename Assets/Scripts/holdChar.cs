using UnityEngine;
using System.Collections;

public class holdChar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{
		Debug.Log ("COllided");
		col.transform.localScale = new Vector3 (1,1,1);
		col.transform.parent = transform;
	}

}
