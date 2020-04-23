using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 
public class FirstIntro : MonoBehaviour {
 
    public int num;
 
    // Use this for initialization
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(num);
        }
    }
}