using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed;
	public float timeToTurn;
	public float timeToJump;

	public float jumpForce = 50f;
	public float jumpDelay = 2f;

	private Rigidbody2D rBody;
	private float savedTimeMove = 1;
	private float savedTimeJump = 1;

	private float nextJumpTime = 1;

	// Use this for initialization
	void Start() {
		rBody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update() {
		transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
		if (Time.time - savedTimeMove >= timeToTurn) {
			speed *= -1;
			savedTimeMove = Time.time;
		}

		if (nextJumpTime <= Time.time) {
			rBody.AddForce(new Vector2(0, jumpForce));
			nextJumpTime = Time.time + jumpDelay;
		}
	}
}
