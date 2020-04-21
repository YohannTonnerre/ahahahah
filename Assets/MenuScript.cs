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
        menuPanel.gameObject.SetActive(false);

        waitingForKey = false;

        for(int i = 0; i < menuPanel.childCount; i++) {

            if(menuPanel.GetChild(i).name == "ForwardKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.forward.ToString();

            else if(menuPanel.GetChild(i).name == "BackwardKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.backward.ToString();

            else if(menuPanel.GetChild(i).name == "LeftKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.left.ToString();

            else if(menuPanel.GetChild(i).name == "RightKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.right.ToString();
        }
    }

    void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Escape) && !menuPanel.gameObject.activeSelf)
            menuPanel.gameObject.SetActive(true);

        else if(Input.GetKeyDown(KeyCode.Escape) && menuPanel.gameObject.activeSelf)
            menuPanel.gameObject.SetActive(false);

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
            GameManager.GM.forward = newKey;
            buttonText.text = GameManager.GM.forward.ToString();
            PlayerPrefs.SetString("forwardKey", GameManager.GM.forward.ToString());
            break;

        case "backward":
            GameManager.GM.backward = newKey;
            buttonText.text = GameManager.GM.backward.ToString();
            PlayerPrefs.SetString("backwardKey", GameManager.GM.backward.ToString());
            break;

        case "left":
            GameManager.GM.left = newKey;
            buttonText.text = GameManager.GM.left.ToString();
            PlayerPrefs.SetString("leftKey", GameManager.GM.left.ToString());
            break;

        case "right":
            GameManager.GM.right = newKey;
            buttonText.text = GameManager.GM.right.ToString();
            PlayerPrefs.SetString("rightKey", GameManager.GM.right.ToString());
            break;

        }

        yield return null;
    }
}