using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathOnCollide : MonoBehaviour {
	private void OnCollisionEnter2D(Collision2D collision) {
		GameObject gObj = collision.gameObject;

		if (gObj.CompareTag("Player")) {
			SceneManager.LoadScene(1);
		}
	}

}
