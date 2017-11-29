using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    private float savedTime = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        if (Time.time - savedTime >= 5)
        {
            speed *= -1;
        }
        savedTime = Time.time;
    }
}
