using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuController : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    // Switch to another level
    public void switchLevel(string levelName)
    {
        SceneManager.LoadSceneAsync(levelName);
    }

}
