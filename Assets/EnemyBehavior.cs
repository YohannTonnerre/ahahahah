using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class EnemyBehavior : MonoBehaviour
{



    public Transform[] waypoints;
    int cur = 0;
    public float speed = 5;


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


            if(PlayerBehavior.Life > 1){
                PlayerBehavior.Life -= 1;
            }
            else{
                Destroy(node.gameObject);  
                SceneManager.LoadScene("4_PageLoose");            
            }
        }
    

    }

}
