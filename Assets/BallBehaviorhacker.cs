﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviorhacker : MonoBehaviour
{

    private float m_speed = 500f;
    public Rigidbody2D m_rb2D;
    public float BulletDestroyTimer = 1f;
   





    // Update is called once per frame
    void FixedUpdate()
    {
       


            transform.Translate(Vector3.left * Time.deltaTime * m_speed);
            Destroy(gameObject, BulletDestroyTimer);



        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {



        
    }

}
