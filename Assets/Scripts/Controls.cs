using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour {

	private Rigidbody rb;
	public Transform player;
	public int speed,thrust;
	private bool isGrounded = false;
	private bool zway = false,touched;
	public bool dead = false;
	public float move = 0;
	public bool boolean = false;
	public SphereCollider rbCol;
	public GameObject ball, pieces;
	private GameObject pcs;
	public Camera nearCam, farCam;
	public static bool check = false;
	private int curr_level;


	// Use this for initialization
	void Start () { 
		farCam.enabled = false;
		nearCam.enabled = true;
		rb = GetComponent<Rigidbody> ();
		rb.maxAngularVelocity = 12;
	}
	
	// Update is called once per frame
	void Update () {
		if (zway == false) {
			
		}
		if (zway == true) {
			
		}
		if (Input.GetKey (KeyCode.D)) {
			rb.AddTorque (Vector3.back * speed);
		}
		if (Input.GetKey (KeyCode.A)) {
			rb.AddTorque (Vector3.forward * speed);
		}
		if (Input.GetKey (KeyCode.Space) && isGrounded==true) {
			isGrounded = false;
			rb.AddForce (Vector3.up * thrust);
		}
		if (Input.GetKey (KeyCode.W) && zway==true) {
			rb.AddTorque (Vector3.right * speed);
		}
		if (Input.GetKey (KeyCode.S) && zway==true) {
			rb.AddTorque (Vector3.left * speed);
		}
		if (dead) {
			StartCoroutine ("DeathRoutine");
		}
	}
	public void Move(float b)
	{
		move = b;
	}
	public void Jump(bool b)
	{
		boolean = b;
	}
	void FixedUpdate()
	{
		MoveControls (move);
		JumpControls (boolean);
	}
	void MoveControls(float move)
	{
		if (touched) {
			if (move == 1 || move == -1) {
				rb.AddTorque (move * Vector3.forward * speed);
			}
			if ((move == 2 || move == -2) && zway == true) {
				rb.AddTorque ((move * Vector3.right * speed) / 2);
			}
		}
	}
	void JumpControls(bool boolean)
	{
		if (boolean && isGrounded==true) {
			isGrounded = false;
			rb.AddForce (Vector3.up * thrust);
		}
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.collider.tag == "plt") {
			touched = true;
			isGrounded = true;
			zway = false;
		}
		else{
			isGrounded = false;
			zway = false;
		}
	}
	
	void OnCollisionStay(Collision col)
	{
		if (col.collider.tag == "zway") {
			isGrounded = true;
			zway = true;
			rb.constraints = RigidbodyConstraints.None;
			rb.maxAngularVelocity = 3;
			thrust = 80;
		}
		if (col.collider.tag == "sway") {
			isGrounded = true;
			zway = true;
			rb.constraints = RigidbodyConstraints.None;
			thrust = 80;
		}
	}
	void OnCollisionExit(Collision col)
	{
		if (col.collider.tag == "zway") {
			zway = false;
			rb.constraints = RigidbodyConstraints.FreezePositionZ;
			rb.maxAngularVelocity = 12;
			thrust = 280;
		}
		if (col.collider.tag == "sway") {
			zway = false;
			rb.constraints = RigidbodyConstraints.FreezePositionZ;
			thrust = 280;

		}
	}

	void Revive()
	{
		rb.isKinematic = false;
		rbCol.enabled = true;
		ball.SetActive (true);
	}

	IEnumerator DeathRoutine()
	{	
		if (check == false) {
			Buoyancy.inWater = false;
			rb.drag = 0.05f;
			dead = false;
			farCam.enabled = false;
			nearCam.enabled = true;
			zway = false;
			rb.isKinematic = true;
			rbCol.enabled = false;
			ball.SetActive (false);
			pcs = Instantiate (pieces.gameObject, player.position, player.rotation) as GameObject;
			Destroy (pcs.gameObject,5f);
			yield return new WaitForSeconds (3f);
			if (PlayerPrefs.GetInt ("SaveLevel") == 1) {
				SceneManager.LoadScene ("Level_1");
			}else if (PlayerPrefs.GetInt ("SaveLevel") == 2) {
				SceneManager.LoadScene ("Level_2");
			}

		} else if(check==true){
			Buoyancy.inWater = false;
			rb.drag = 0.05f;
			farCam.enabled = false;
			nearCam.enabled = true;
			Debug.Log ("DeadCheckpoint");
			dead = false;
			zway = false;
			rb.isKinematic = true;
			rbCol.enabled = false;
			ball.SetActive (false);
			pcs = Instantiate (pieces.gameObject, player.position, player.rotation) as GameObject;
			Destroy (pcs.gameObject,5f);
			yield return new WaitForSeconds (3f);
			Revive ();
			transform.position = Checkpoint.reachedPoint;
		}
	}
}
