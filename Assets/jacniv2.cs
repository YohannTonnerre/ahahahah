using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jacniv2 : MonoBehaviour
{
    private Vector2 direction = Vector2.zero;
    public float m_speed = 100f;
    public Rigidbody2D m_rb2D;
    
    // Start is called before the first frame update
    void Start()
    {

       
    }

     void CheckInput() {
    	if (Input.GetKeyDown (GameManager.left)) {
    		direction = Vector2.left;
    	} else if (Input.GetKeyDown (GameManager.right)) {
    		direction = Vector2.right;
    	} else if (Input.GetKeyDown (GameManager.forward)) {
    		direction = Vector2.up;
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
}
