using UnityEngine;
using System.Collections;

public class handActions : MonoBehaviour {
    
    private RaycastHit hit;
    private float range = 3;
    public GameObject paper;
    public GameObject gun;
    public GameObject gunCha;
    private bool gunOB = false;
    public GameObject lighta;
    public GameObject lightCha;
    private bool lightOB = false;
    public GameObject book;
    private bool bookOB = false;
    private bool holding = false;

	
	// Update is called once per frame
	void Update () {
        if ( Input.GetKeyDown(KeyCode.F) && !holding)
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, range) && hit.transform.name == "clue1" && !holding)
            {
                book.SetActive(false);
                paper.SetActive(true);
                bookOB = true;
                holding = true;
            }
            else if (Physics.Raycast(transform.position, transform.forward, out hit, range) && hit.transform.name == "gunWall" && !holding)
            {
                gun.SetActive(false);
                gunCha.SetActive(true);
                gunOB = true;
                holding = true;
            }
            else if (Physics.Raycast(transform.position, transform.forward, out hit, range) && hit.transform.name == "lightWall" && !holding)
            {
                lighta.SetActive(false);
                lightCha.SetActive(true);
                lightOB = true;
                holding = true;
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.E) && bookOB)
        {
            if (bookOB && holding) paper.SetActive(false);
            else if (!holding) paper.SetActive(true);
            holding = !holding;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) && gunOB)
        {
            if (gunOB && holding) gunCha.SetActive(false);
            else if (!holding) gunCha.SetActive(true);
            holding = !holding;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && lightOB)
        {
            if (lightOB && holding) lightCha.SetActive(false);
            else if (!holding) lightCha.SetActive(true);
            holding = !holding;
        }
    }
}
