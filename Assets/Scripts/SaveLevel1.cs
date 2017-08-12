using UnityEngine;
using System.Collections;

public class SaveLevel1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("SaveLevel",1);
	}
}
