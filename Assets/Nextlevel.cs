using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlevel : MonoBehaviour
{
   

     public void NextLevel ()
    {
        SceneManager.LoadScene("2_Boss");
    }
}
