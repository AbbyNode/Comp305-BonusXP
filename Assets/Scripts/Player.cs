using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float maxSpeed = 8;
	public float jumpDelay = 1;
	public float jumpForce = 50;

	public float health = 100f;

	private Rigidbody2D rBody;
	private float nextJumpTime;

	void Start() {
		rBody = this.GetComponent<Rigidbody2D>();
		nextJumpTime = 0;
	}

	void Update() {
		if (health <= 0) {
			// TODO: Die
		}

		float moveX = Input.GetAxis("Horizontal");
		if (moveX != 0) {
			float moveAmt = Time.deltaTime * moveX;
			Vector3 moveVec3 = transform.right * moveAmt;
			Vector2 moveVec2 = rBody.position + (new Vector2(moveVec3.x, moveVec3.y));

			rBody.velocity = new Vector2(moveAmt * maxSpeed, rBody.velocity.y);
			//			rBody.MovePosition(moveVec2);
		}

		bool moveY = Input.GetButton("Vertical");

		if (moveY && nextJumpTime <= Time.time) {
			Debug.Log(nextJumpTime + " " + Time.time);
			rBody.AddForce(new Vector2(0, jumpForce));
			nextJumpTime = Time.time + jumpDelay;
		}
	}

	public void Damage(float amt) {
		health -= amt;
	}
}
