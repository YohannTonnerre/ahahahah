using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Timer : MonoBehaviour
{
    public float start = 10;
 
    private Text time;
 
    private void Start()
    {
        time = GetComponent<Text>();
    }
 
    private void Update()
    {
        start = Mathf.Max(0, start - Time.deltaTime);
        TimeSpan timeSpan = TimeSpan.FromSeconds(start);
        time.text = timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00") + "	";

        if (start <= 1)
        {
            SceneManager.LoadScene("2_Boss");
        }
    }
}
