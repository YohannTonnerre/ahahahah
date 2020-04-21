using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    void Start ()
    {

    } 

    void Update ()
    {
        if(Input.GetKey(GameManager.GM.forward))
            transform.position += Vector3.forward / 2;

        if( Input.GetKey(GameManager.GM.backward))
            transform.position += -Vector3.forward / 2;

        if( Input.GetKey(GameManager.GM.left))
            transform.position += Vector3.left / 2;

        if( Input.GetKey(GameManager.GM.right))
            transform.position += Vector3.right / 2;
    }
}