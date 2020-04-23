using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jacniv2 : MonoBehaviour
{
    private Vector2 direction = Vector2.zero;
    public float m_speed = 100f;
    public Rigidbody2D m_rb2D;
    public bool isGrounded = false;
    public Sprite JUMP;
    public Sprite Grounded;
    public float BulletSpeed = 1000f;
    public Rigidbody2D Bullet; 


    private float RouterRate = 0.5f;

    private float RouterFire;

    void Start()
    {

       
    }

     void CheckInput() {
    	if (Input.GetKeyDown (GameManager.left)) {
    		direction = Vector2.left;
    	} else if (Input.GetKeyDown (GameManager.right)) {
    		direction = Vector2.right;
    	} else if (Input.GetKeyDown (GameManager.forward) && isGrounded == true){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 120f), ForceMode2D.Impulse);
        }   
        else if (isGrounded == true){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Grounded;
        }
        else if (isGrounded == false){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = JUMP;
        }
    	
    }

    void Move () {
    	transform.localPosition += (Vector3)(direction * m_speed) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput ();

    	Move ();

    }

    void FixedUpdate(){
         Bullet.MovePosition(Bullet.position + Time.fixedDeltaTime * BulletSpeed * Vector2.up);
         Debug.Log(Bullet.position);
         Debug.Log(Time.fixedDeltaTime);
         Debug.Log(Vector2.up);
        if (Input.GetAxis("Fire1") > 0f && Time.time > RouterFire) {
            RouterFire = Time.time + RouterRate;
            Instantiate(Bullet, transform.localPosition, Quaternion.identity); 
        }
    }

}
