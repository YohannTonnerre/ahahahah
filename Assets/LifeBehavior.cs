using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBehavior : MonoBehaviour
{
	public Sprite FiveLife;
	public Sprite FourLife;
	public Sprite ThreeLife;
	public Sprite TwoLife;
	public Sprite OneLife;
	public Sprite ZeroLife;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(PlayerBehavior.Life == 5){
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = FiveLife;
        }
        if(PlayerBehavior.Life == 4){
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = FourLife;
        }
        if(PlayerBehavior.Life == 3){
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = ThreeLife;
        }
        if(PlayerBehavior.Life == 2){
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = TwoLife;
        }
        if(PlayerBehavior.Life == 1){
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = OneLife;
        }
        if(PlayerBehavior.Life == 0){
        	this.gameObject.GetComponent<SpriteRenderer>().sprite = ZeroLife;
        }
    
    }
}
