using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollide : MonoBehaviour {
	public float damageAmt;
	
	private void OnCollisionEnter2D(Collision2D collision) {
		GameObject gObj = collision.gameObject;

		if (gObj.CompareTag("Player")) {
			gObj.GetComponent<Player>().Damage(damageAmt);
		}
	}
}
