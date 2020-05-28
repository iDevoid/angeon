using UnityEngine;
using System.Collections;

public class bodyHit : MonoBehaviour {

    public GameObject finisher;
    private int hit;
    public AudioClip slow;
    public AudioClip fast;
    public GameObject gate;

    void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (other.transform.tag == "Enemies")
        {
            //Kalah
            GameObject.Find("FPSController").GetComponent<CharacterController>().enabled = false;
            GameObject.Find("gun").GetComponent<Animator>().SetBool("finish", true);
            finisher.SetActive(true);
        }
        else if (other.transform.name == "Medium Room 2")
        {
            gate.SetActive(false);
        }
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.transform.name == "ChaDragon")
        {
            hit++;
            if (hit > 5)
                GameObject.Find("Capsule").GetComponent<AudioSource>().clip = slow;
            else if (hit > 10)
                GameObject.Find("Capsule").GetComponent<AudioSource>().clip = fast;
            else if (hit > 15)
            {
                GameObject.Find("FPSController").GetComponent<CharacterController>().enabled = false;
                GameObject.Find("gun").GetComponent<Animator>().SetBool("finish", true);
                finisher.SetActive(true);
            }
        }
    }
}
