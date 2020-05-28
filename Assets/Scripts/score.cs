using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public int skore = 1;
    private int hit = 0;
    private int dead;
    public GameObject finisher;

    // Use this for initialization
    void Start () {
        dead = 10000000 * skore;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void updateScore()
    {
        skore++;
        GameObject.Find("Scores").GetComponent<Text>().text = "Enemy killed: " + skore.ToString();
    }

    public void hitDragon()
    {
        hit++;
        if (hit > dead)
        {
            Destroy(GameObject.Find("ChaDragon").gameObject);
            finisher.SetActive(true);
            GameObject.Find("doneText").GetComponent<Text>().text = "YOU FINISH IT!";
            GameObject.Find("FPSController").GetComponent<CharacterController>().enabled = false;
            GameObject.Find("gun").GetComponent<Animator>().SetBool("finish", true);
        }
    }
}
