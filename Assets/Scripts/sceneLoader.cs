using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour {

	// Use this for initialization
	public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void desScene(string scene)
    {
        SceneManager.LoadScene("mainMenu");
    }
}
