using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cle_icon : MonoBehaviour
{

	public Sprite Cle_no;
	public Sprite Cle_yes;

    // Start is called before the first frame update
    void Start()
    {
    	this.gameObject.GetComponent<SpriteRenderer>().sprite = Cle_no;
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(PlayerBehavior.bonus_cle == true){
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = Cle_yes;
        }
        
    }
}
