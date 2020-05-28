using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class audioChange : MonoBehaviour {
    
    public void audioMute(GameObject target)
    {
        Debug.Log("Changin Condition on " + target.name);

        if (target.GetComponent<AudioSource>().isPlaying)
        {
            GameObject.Find("muteText").GetComponent<Text>().text = "Unmute";
            target.GetComponent<AudioSource>().Pause();
        }
        else
        {
            GameObject.Find("muteText").GetComponent<Text>().text = "Mute";
            target.GetComponent<AudioSource>().Play();
        }
    }
}
