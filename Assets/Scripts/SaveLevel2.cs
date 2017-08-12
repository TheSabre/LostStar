using UnityEngine;
using System.Collections;

public class SaveLevel2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Controls.check = false;
		Checkpoint.reachedPoint = GameObject.Find ("Rover").GetComponent<Transform> ().position;
		PlayerPrefs.SetInt ("SaveLevel",2);
	}
}
