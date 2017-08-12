using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	private Transform end;
	public Transform chapters_pos;
	public Transform aboutus_pos;
	public Transform mainmenu_pos;
	public float to;
	public Canvas Main_Menu, Chapters,AboutUs;
	private Canvas current_can;
	public AudioSource sound;

	void Start()
	{
		
		Chapters.enabled = false;
		AboutUs.enabled = false;
	}

	public void newgame()
	{
		sound.Play();
		SceneManager.LoadScene ("Level_1");
	}
		
	public void quitgame()
	{
		sound.Play ();
		Debug.Log ("Quit!");
		Application.Quit ();
	}

	public void chapters()
	{
		sound.Play ();
		Main_Menu.enabled = false;
		current_can = Chapters;
		var start = transform.position;
		end = chapters_pos;
		StartCoroutine (MoveCam(transform,start,end.position,to,current_can));
	}

	public void chapters_back()
	{
		sound.Play ();
		current_can = Main_Menu;
		Chapters.enabled = false;
		var start = transform.position;
		end = mainmenu_pos;
		StartCoroutine (MoveCam(transform,start,end.position,to,current_can));
	}

	public void aboutus()
	{
		sound.Play ();
		current_can = AboutUs;
		Main_Menu.enabled = false;
		var start = transform.position;
		end = aboutus_pos;
		StartCoroutine (MoveCam(transform,start,end.position,to,current_can));
	}

	public void aboutus_back()
	{
		sound.Play ();
		current_can = Main_Menu;
		AboutUs.enabled = false;
		var start = transform.position;
		end = mainmenu_pos;
		StartCoroutine (MoveCam(transform,start,end.position,to,current_can));
	}

	IEnumerator MoveCam(Transform thisTransform, Vector3 pointA, Vector3 pointB, float time, Canvas can)
	{
		var t = 0.0f;
		var rate = 1.0f/ time;

		while(t<1.0f)
		{
			t += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp (pointA, pointB, t);
			yield return null;
		}
		can.enabled = true;
	}
		
}
