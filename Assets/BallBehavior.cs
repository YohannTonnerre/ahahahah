using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{

    public float m_speed = 1000f;
    public Rigidbody2D m_rb2D;
    public float BulletDestroyTimer = 1f;



    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") < 0f) { 
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.left);
            Destroy(gameObject, BulletDestroyTimer);
        }

        if (Input.GetAxis("Horizontal") > 0f)
        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.right);
            Destroy(gameObject, BulletDestroyTimer);

        }

        if (Input.GetAxis("Vertical") < 0f)
        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.down);
            Destroy(gameObject, BulletDestroyTimer);
        }

        if (Input.GetAxis("Vertical") > 0f)
        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.up);
            Destroy(gameObject, BulletDestroyTimer);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "BoxWood")
        {
            Destroy(collision.gameObject);
        }
    }

}
