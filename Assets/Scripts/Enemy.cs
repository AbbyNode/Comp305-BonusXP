using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    public float timeToTurn;
    public float timeToJump;
    private Rigidbody2D rb;
    private float savedTimeMove = 1;
    private float savedTimeJump = 1;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        if (Time.time - savedTimeMove >= timeToTurn) 
        {
            speed *= -1;
            savedTimeMove = Time.time;
        }
        if (Time.time - savedTimeJump >= timeToJump)
        {
            //rb.AddForce(new Vector2(0, 10));
            rb.AddForce(new Vector2(0,5) * speed * Time.deltaTime);
            savedTimeJump = Time.time;
        }

    }
}
