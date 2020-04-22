using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("1_PacMan");
    }

    public void QuitGame ()
    {
        Application.Quit(); // Ferme le jeu
    }

     public void InputsGame ()
    {
        SceneManager.LoadScene("_GestionInput");
    }

     public void niv2 ()
    {
        SceneManager.LoadScene("2_Boss");
    }
}
