using UnityEngine;
using System.Collections;

public class bulletHit : MonoBehaviour {

    private GameObject skor;

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Enemies")
        {
            GameObject.Find("scor").GetComponent<score>().updateScore();
            Destroy(other.gameObject);
        }
        if (other.transform.name == "ChaDragon")
        {
            Debug.Log("HIT");
            GameObject.Find("scor").GetComponent<score>().hitDragon();
        }
    }
}
