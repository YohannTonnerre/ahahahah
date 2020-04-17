using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{


    public float m_speed = 100f;
    public Rigidbody2D m_rb2D;
    public int m_score = 0;
    public int bonus_r = 0;
    public bool bonus_cle = false;
    public GameObject m_ball;
    public Sprite LEFT;
    public Sprite RIGHT;
    public Sprite BACK;
    public Sprite FRONT;
    public int Life = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") < 0f)
        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.left);
            /*this.gameObject.GetComponent<SpriteRenderer>().sprite = LEFT;*/
        }
        if (Input.GetAxis("Horizontal") > 0f)
        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.right);
            /*this.gameObject.GetComponent<SpriteRenderer>().sprite = RIGHT;*/
        }
        if (Input.GetAxis("Vertical") < 0f)
        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.down);
            /*this.gameObject.GetComponent<SpriteRenderer>().sprite = FRONT;*/
        }
        if (Input.GetAxis("Vertical") > 0f)
        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.up);
            /*this.gameObject.GetComponent<SpriteRenderer>().sprite = BACK;*/
        }
        /*if (Input.GetAxis("Fire1") > 0f)
        {
            Instantiate(m_ball, transform.localPosition, Quaternion.identity);
        }*/
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            ScoreScript.m_score += 1;
        }

        if (collision.gameObject.tag == "routeur")
        {
            Destroy(collision.gameObject);
            ScoreScript.m_score += 5;
            bonus_r = bonus_r + 1;
            m_speed = m_speed + 10;
        }

        if (collision.gameObject.tag == "clé")
        {
            Destroy(collision.gameObject);
            ScoreScript.m_score += 10;
            bonus_cle = true ;
        }

    }

}
