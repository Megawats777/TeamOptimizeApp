using UnityEngine;
using System.Collections;

public class CameraSwitchManager : MonoBehaviour
{
    /*--The Cameras in the level--*/
    public GameObject topCamera;

    public GameObject perspectiveCamera;

	// Use this for initialization
	void Start ()
    {
        // Enable the top camera
        topCamera.SetActive(true);

        // Disable the perspective camera
        perspectiveCamera.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    // Use the top camera
    public void useTopCamera()
    {
        // Enable the top camera
        topCamera.SetActive(true);

        // Disable the perspective camera
        perspectiveCamera.SetActive(false);
    }

    // Use the perspective camera
    public void usePerspectiveCamera()
    {
        // Enable the perspective camera
        perspectiveCamera.SetActive(true);

        // Disable the top camera
        topCamera.SetActive(true);
    }

}
