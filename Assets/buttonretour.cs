using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class buttonretour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void ButtonRetour ()
    {
        SceneManager.LoadScene("0_Menu");
        PlayerBehavior.Life = 3;
        ScoreScript.m_score = 0;
        PlayerBehavior.bonus_r = 0;
        PlayerBehavior.bonus_cle = false;
    }

     public void ButtonReco ()
    {
        SceneManager.LoadScene("1_PacMan");
        PlayerBehavior.Life = 3;
        ScoreScript.m_score = 0;
        PlayerBehavior.bonus_r = 0;
        PlayerBehavior.bonus_cle = false;
        PlayerBehavior.nb_r = 0;
        
    }

     public void ButtonLevelup ()
    {
        SceneManager.LoadScene("2_Boss");
    }
}
