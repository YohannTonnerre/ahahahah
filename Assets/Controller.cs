using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    void Start ()
    {

    } 

    void Update ()
    {
        if(Input.GetKey(GameManager.forward))
            transform.position += Vector3.forward / 2;

        if( Input.GetKey(GameManager.backward))
            transform.position += -Vector3.forward / 2;

        if( Input.GetKey(GameManager.left))
            transform.position += Vector3.left / 2;

        if( Input.GetKey(GameManager.right))
            transform.position += Vector3.right / 2;
    }
}