using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vieBoss : MonoBehaviour
{
    public Sprite wifi0;
    public Sprite wifi1;
    public Sprite wifi2;
    public Sprite wifi3;
    public Sprite wifi4;
    public Sprite wifi5;

    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
        if (HackerBehavior.hackerLife == 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = wifi5; 
        }
        else if (HackerBehavior.hackerLife == 8)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = wifi4; 
        }
        else if (HackerBehavior.hackerLife == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = wifi3; 
        }
        else if (HackerBehavior.hackerLife == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = wifi2; 
        }
        else if (HackerBehavior.hackerLife == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = wifi1; 
        }
        else if (HackerBehavior.hackerLife == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = wifi0; 
        }
        else if (HackerBehavior.hackerLife == 0)
        {
            SceneManager.LoadScene("3_PageWin");
        }
        
    }
}
