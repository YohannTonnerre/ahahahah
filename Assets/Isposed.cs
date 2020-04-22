using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;


public class Isposed : MonoBehaviour
{

	public bool isPauseded = false;
	public Sprite PauseImg;
	public Sprite PlayImg;

    public Texture2D buttonImageContinuer = null;
    public Texture2D buttonImageQuitter = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Pause();
        }
    }

    public void Pause(){
    	isPauseded = !isPauseded;
    	if(isPauseded){
    	    Time.timeScale = 0f;
    	}
    	else
    	    Time.timeScale = 1f;
    }

    void OnGUI () 
    {

         GUI.backgroundColor = Color.clear;
        if(isPauseded)
        {
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = PlayImg;
			Time.timeScale = 0f;
            // Si on clique sur le bouton alors isPauseded devient faux donc le jeu reprend
            if(GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 - 20, buttonImageContinuer.width / 15, buttonImageContinuer.height / 15),buttonImageContinuer))
            {
                isPauseded = false;
            }
            // Si on clique sur le bouton alors on ferme completment le jeu ou on charge la scene Menu Principal
            // Dans le cas du bouton Quitter, il faut augmenter sa position Y pour qu'il soit plus bas.
            if(GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 40, buttonImageQuitter.width/ 15, buttonImageQuitter.height / 15),buttonImageQuitter))
            {
                SceneManager.LoadScene("0_Menu"); // Charge le menu principal
            }
        }
        //test
        else{
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = PauseImg;
			Time.timeScale = 1f;
        }
    }
}
