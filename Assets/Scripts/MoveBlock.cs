using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour {
    public double maxJump;
    public double minJump;
    private Transform currentPos;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        currentPos = this.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
       
        this.rb.gravityScale = 0.5f;
       
        if (currentPos.position.y <= minJump)
        {
            this.rb.gravityScale = -1;
       
        }

    }
}
