using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GetLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void getLevel()
	{
		if (PlayerPrefs.GetInt ("SaveLevel") == 1) {
			SceneManager.LoadScene ("Level_1");
		} else if (PlayerPrefs.GetInt ("SaveLevel") == 2) {
			SceneManager.LoadScene ("Level_2");
		} 
	}
}
