﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Router_icon2 : MonoBehaviour
{
    public Sprite Router_no;
	public Sprite Router_yes;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Router_no;
    }

    // Update is called once per frame
    void Update()
    {
    	if(PlayerBehavior.nb_r >= 2){
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = Router_yes;
        }
    }
}
