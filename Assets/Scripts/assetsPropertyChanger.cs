using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class assetsPropertyChanger : MonoBehaviour {

    public void change(string targetName, string text)
    {
        Debug.Log("Changing text on " + targetName);
        GameObject.Find(targetName).GetComponent<Text>().text = text;
    }

    public void changeByCondition(string targetName, string FirstText, string lastText)
    {
        Debug.Log("Changing text on " + targetName);
        if (GameObject.Find(targetName).GetComponent<Text>().text == FirstText)
            GameObject.Find(targetName).GetComponent<Text>().text = lastText;
        else
            GameObject.Find(targetName).GetComponent<Text>().text = FirstText;
    }

    public void changeAudioVolume(string targetName, float value)
    {
        Debug.Log("Changing condition on " + targetName);
        GameObject.Find(targetName).GetComponent<AudioSource>().volume = value;
        
    }
}
