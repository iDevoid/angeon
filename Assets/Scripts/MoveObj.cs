using UnityEngine;
using System.Collections;

public class MoveObj : MonoBehaviour {

    public GameObject prefabsPeluru;
	public GameObject samplePeluru;
    GameObject peluru;
    public GameObject done;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && !GameObject.Find("gun").GetComponent<Animator>().GetBool("finish"))
        {
            Vector3 pos = samplePeluru.transform.position;
            peluru = Instantiate(prefabsPeluru, pos, Quaternion.identity) as GameObject;
            GameObject.Find("gunSound").GetComponent<AudioSource>().Play();
            peluru.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            GameObject.Find("gun").GetComponent<Animator>().SetTrigger("shoot");
            peluru.transform.tag = "bullets";
            peluru.transform.parent = GameObject.Find("bulletTrash").transform.parent;
            Destroy(peluru, 3);
        }
    }
}
