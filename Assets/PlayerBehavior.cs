using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{


    public float m_speed = 100f;
    public Rigidbody2D m_rb2D;
    public int m_score = 0;
    public static int bonus_r = 0;
    public static bool bonus_cle = false;
    public GameObject m_ball;
    public static int Life = 3;
    private Vector2 direction = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    	CheckInput ();

    	Move ();

    }

    void CheckInput() {
    	if (Input.GetKeyDown (GameManager.left)) {
    		direction = Vector2.left;
    	} else if (Input.GetKeyDown (GameManager.right)) {
    		direction = Vector2.right;
    	} else if (Input.GetKeyDown (GameManager.forward)) {
    		direction = Vector2.up;
    	} else if (Input.GetKeyDown (GameManager.backward)) {
    		direction = Vector2.down;
    	}
    	
    }

    void Move () {
    	transform.localPosition += (Vector3)(direction * m_speed) * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            ScoreScript.m_score += 100;
        }

        if (collision.gameObject.tag == "routeur")
        {
            Destroy(collision.gameObject);
            ScoreScript.m_score += 500;
            bonus_r = bonus_r + 1;
            m_speed = m_speed + 100;
        }

        if (collision.gameObject.tag == "clé")
        {
            Destroy(collision.gameObject);
            ScoreScript.m_score += 1000;
            bonus_cle = true ;
        }
        if (collision.gameObject.tag == "Obstacle") {
    		direction = Vector2.zero;
    	}

    }

}
