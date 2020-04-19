using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBindScript : MonoBehaviour
{

	private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();

	public static Text up, down, left, right;

	private GameObject currentKey;

	private Color32 normal = new Color(39, 171, 249, 255);
	private Color32 slected = new Color32(239, 116, 36, 255);
    // Start is called before the first frame update
    void Start()
    {
    	keys.Add("Up",(KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Up","Z")));
        keys.Add("Down",(KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Down","S")));
        keys.Add("Left",(KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Left","Q")));
        keys.Add("Right",(KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Right","D")));

        up.text = keys["Up"].ToString();
        down.text = keys["Down"].ToString();
        left.text = keys["Left"].ToString();
        right.text = keys["Right"].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keys["Up"])){
        	//action
        	Debug.Log("Up");
        }

        if (Input.GetKeyDown(keys["Down"])){
        	//action
        	Debug.Log("Down");
        }

        if (Input.GetKeyDown(keys["Left"])){
        	//action
        	Debug.Log("Left");
        }

        if (Input.GetKeyDown(keys["Right"])){
        	//action
        	Debug.Log("Right");
        }
    }

    void OnGUI(){
    	if (currentKey != null){
    		Event e = Event.current;
    		if (e.isKey){
    			keys[currentKey.name] = e.keyCode;
    			currentKey.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
    			currentKey.GetComponent<Image>().color = normal;
    			currentKey = null;
    		}
    	}
    }

    public void ChangeKey(GameObject clicked){
    	if (currentKey != null){
    		currentKey.GetComponent<Image>().color = normal;
    	}
    	currentKey = clicked;
    	currentKey.GetComponent<Image>().color = slected;
    }

    public void saveKeys(){
    	foreach (var key in keys){
    		PlayerPrefs.SetString(key.Key,key.Value.ToString());

    	}
    	PlayerPrefs.Save();
    }


}
