using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HackerBehavior : MonoBehaviour
{
    public static  int hackerLife = 10;


    public Rigidbody2D m_rb2D;
    public float accelerationTime = 120f;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;
    private float m_speed = 500f;
    public float BulletSpeed = 1000f;
    public Rigidbody2D Bullet;
    private float RouterRate = 1f;
    public Sprite HackerBADCorps;
    public Sprite shooting;
    public Sprite HackerGOODCorps;

    private float RouterFire;


    void Start(){

    }
    
    void Update()
    {
      timeLeft -= Time.deltaTime;
      if(timeLeft <= 0)
      {
        movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        timeLeft += accelerationTime;
      }
    }
    
    void FixedUpdate()
    {
      	m_rb2D.AddForce(movement * maxSpeed);
      	 if (Time.time > RouterFire) {
            RouterFire = Time.time + RouterRate;
            Instantiate(Bullet, transform.localPosition, Quaternion.identity); 
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = shooting;
        }
        else if (hackerLife >= 5){
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = HackerGOODCorps; 
        	}   

        else if (hackerLife < 5){
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = HackerBADCorps; 
        	}     	

        else if(hackerLife <= 1){
        	SceneManager.LoadScene("3_PageWin");
        }
    }
}
