using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour {

	public Canvas canTrue,canFalse;

	// Use this for initialization
	void Start () {
		canTrue.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			canFalse.enabled = false;
			canTrue.enabled = true;
			Invoke ("LevelCompleted", 4f);
		}
	}

	void LevelCompleted()
	{
		SceneManager.LoadScene ("Level_2");	
	}
}
