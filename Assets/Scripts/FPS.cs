using UnityEngine;
using System.Collections;

public class FPS : MonoBehaviour {

    public float lookSens = 5f;
    public float xRot;
    public float yRot;
    public float currentXRot;
    public float currentYRot;
    public float xRotV;
    public float yRotV;
    public float lookSmoth = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        xRot -= Input.GetAxis("Mouse Y") * lookSens;
        yRot += Input.GetAxis("Mouse X") * lookSens;
        xRot = Mathf.Clamp(xRot, -90, 90);

        currentXRot = Mathf.SmoothDamp(currentXRot, xRot, ref xRotV, lookSmoth);
        currentYRot = Mathf.SmoothDamp(currentYRot, yRot, ref yRotV, lookSmoth);

        transform.rotation = Quaternion.Euler(xRot, yRot, 0);
	}
}
