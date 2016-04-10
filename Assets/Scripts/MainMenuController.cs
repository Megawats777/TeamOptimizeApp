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

    // Exit the program
    public void exitProgram()
    {
        Application.Quit();
        print("Program End");
    }
}
