using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour {
	public float force = -10;
	public float turnAmt = 10;

	void Start() {
		Rigidbody2D rBody = this.GetComponent<Rigidbody2D>();
		rBody.AddForce(new Vector2(force, 0));
		rBody.AddTorque(turnAmt);
	}
}
