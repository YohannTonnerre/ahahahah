using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{



    public Transform[] waypoints;
    int cur = 0;
    public float speed = 5;
    private float hitLast = 0;
    private float hitDelay = 1;


    void Start(){

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // Waypoint not reached yet? then move closer
        if (transform.position != waypoints[cur].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position,
                                            waypoints[cur].position,
                                            speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }

        // Waypoint reached, select next one
        
        else cur = (cur + 1) % waypoints.Length;
    }

    void OnTriggerEnter2D(Collider2D node)
    {
        if (node.gameObject.tag == "Player")
        {
            if(PlayerBehavior.Life == 3 ){
                PlayerBehavior.Life -= 1;
                Debug.Log("aaaa");
            }

            if(PlayerBehavior.Life == 2){
                PlayerBehavior.Life -= 1;
                Debug.Log("bbbb");
            }
            else{
                Destroy(node.gameObject);  
                Debug.Log("cccc");              
            }
        }
    

    }

}
