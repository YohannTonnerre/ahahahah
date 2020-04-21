using UnityEngine;
using System.Collections;
 
public class GameManager : MonoBehaviour {
 
    public static GameManager GM;

    public static KeyCode forward {get; set;}
    public static KeyCode backward {get; set;}
    public static KeyCode left {get; set;}
    public static KeyCode right {get; set;}
 
 
 
    void Awake()
    {
        if(GM == null)
        {
            DontDestroyOnLoad(gameObject);
            GM = this;
        }
        else if(GM != this)
        {
            Destroy(gameObject);
        }
        forward = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("forwardKey", "Z"));
        backward = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("backwardKey", "S"));
        left = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("leftKey", "Q"));
        right = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("rightKey", "D"));

        Debug.Log(forward);
        Debug.Log(backward);
        Debug.Log(left);
        Debug.Log(right);
 
    }
 
    void Start ()
    {
 
    }
 
    void Update ()
    {
    }
}