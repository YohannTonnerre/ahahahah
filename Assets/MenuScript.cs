using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

    Transform menuPanel;
    Event keyEvent;
    Text buttonText;
    KeyCode newKey;

    bool waitingForKey;

    void Start ()
    {
		menuPanel = transform.Find("Panel");
        menuPanel.gameObject.SetActive(true);

        waitingForKey = false;

        for(int i = 0; i < menuPanel.childCount; i++) {

            if(menuPanel.GetChild(i).name == "ForwardKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.forward.ToString();

            else if(menuPanel.GetChild(i).name == "BackwardKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.backward.ToString();

            else if(menuPanel.GetChild(i).name == "LeftKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.left.ToString();

            else if(menuPanel.GetChild(i).name == "RightKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.right.ToString();
        }
    }

    void Update ()
    {
		/*if(Input.GetKeyDown(KeyCode.Escape) && !menuPanel.gameObject.activeSelf)
            menuPanel.gameObject.SetActive(true);

        else if(Input.GetKeyDown(KeyCode.Escape) && menuPanel.gameObject.activeSelf)
            menuPanel.gameObject.SetActive(false);*/

    }

 

    void OnGUI()
    {        
        keyEvent = Event.current;

 		if(keyEvent.isKey && waitingForKey)
        {
            newKey = keyEvent.keyCode;
            waitingForKey = false;
        }
    }

    public void StartAssignment(string keyName)
    {
        if(!waitingForKey)
            StartCoroutine(AssignKey(keyName));
    }

    public void SendText(Text text)
    {
        buttonText = text;
    }

    IEnumerator WaitForKey()
    {
        while(!keyEvent.isKey)
            yield return null;
    }

    public IEnumerator AssignKey(string keyName)
    {
        waitingForKey = true;

        yield return WaitForKey();

        switch(keyName)
        {
        case "forward":
            GameManager.forward = newKey;
            buttonText.text = GameManager.forward.ToString();
            PlayerPrefs.SetString("forwardKey", GameManager.forward.ToString());
            break;

        case "backward":
            GameManager.backward = newKey;
            buttonText.text = GameManager.backward.ToString();
            PlayerPrefs.SetString("backwardKey", GameManager.backward.ToString());
            break;

        case "left":
            GameManager.left = newKey;
            buttonText.text = GameManager.left.ToString();
            PlayerPrefs.SetString("leftKey", GameManager.left.ToString());
            break;

        case "right":
            GameManager.right = newKey;
            buttonText.text = GameManager.right.ToString();
            PlayerPrefs.SetString("rightKey", GameManager.right.ToString());
            break;

        }

        yield return null;
    }
}