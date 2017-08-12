using UnityEngine;
using System.Collections;

public class LerpIt : MonoBehaviour {

	public Transform end;
	public float to;
	public float fro;

	IEnumerator Start()
	{
		
		var start = transform.position;
		while (true) {
			yield return StartCoroutine (MoveObject(transform,start, end.position, to));
			yield return StartCoroutine (MoveObject(transform,end.position, start, fro));
		}
	}

	IEnumerator MoveObject(Transform thisTransform, Vector3 pointA, Vector3 pointB, float time)
	{
		var t = 0.0f;
		var rate = 1.0f/ time;

		while(t<1.0f)
		{
			t += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp (pointA, pointB, t);
			yield return null;
		}

	}

}
