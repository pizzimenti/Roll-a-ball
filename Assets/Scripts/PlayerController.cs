using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		spawnPoint = transform.position;
	}


	void FixedUpdate () { 	
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);

		if (transform.position.y < -10) {
			transform.position = spawnPoint;
		}
	}
}
