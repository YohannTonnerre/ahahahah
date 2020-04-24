using System.Collections;
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


        if (collision.gameObject.tag == "jacniv2")
        {
            jacniv2.JacLife = jacniv2.JacLife - 1;
            Debug.Log(jacniv2.JacLife); 
        }

        if (jacniv2.JacLife == 0)
        {
            Destroy(collision.gameObject);
        }
        
    }

}
