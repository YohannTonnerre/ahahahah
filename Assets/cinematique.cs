using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cinematique : MonoBehaviour
{
    public void Suivant1 ()
    {
        SceneManager.LoadScene("0_2_Cinematique");
    }

    public void Suivant2 ()
    {
        SceneManager.LoadScene("0_3_Cinematique");
    }

    public void Suivant3 ()
    {
        SceneManager.LoadScene("0_4_Cinematique");
    }

    public void Suivant4 ()
    {
        SceneManager.LoadScene("0_5_Cinematique");
    }

    public void Play ()
    {
        SceneManager.LoadScene("1_PacMan");
    }
}
