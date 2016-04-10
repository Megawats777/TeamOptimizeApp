using UnityEngine;
using System.Collections;

public class CameraSwitchManager : MonoBehaviour
{
    /*--The Cameras in the level--*/
    public GameObject topCamera;
    public GameObject perspectiveCamera;

    public GameObject styleHUD;

    bool isStyleHUDActive = true;

    StyleSelectionManager styleManager;

	// Use this for initialization
	void Start ()
    {
        // Enable the top camera
        topCamera.SetActive(true);

        // Disable the perspective camera
        perspectiveCamera.SetActive(false);

        styleManager = FindObjectOfType<StyleSelectionManager>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    // Use the top camera
    public void useTopCamera()
    {
        if (topCamera.activeSelf != true)
        {
            hideStyleHUD();
        }

        // Enable the top camera
        topCamera.SetActive(true);

        // Disable the perspective camera
        perspectiveCamera.SetActive(false);
    }

    // Use the perspective camera
    public void usePerspectiveCamera()
    {
        if (perspectiveCamera.activeSelf != true)
        {
            hideStyleHUD();
        }

        // Enable the perspective camera
        perspectiveCamera.SetActive(true);

        // Disable the top camera
        topCamera.SetActive(false);
    }

    // Hide the style HUD
    public void hideStyleHUD()
    {
        styleManager.isHUDActive = false;

        isStyleHUDActive = false;
        styleHUD.SetActive(false);
    }

    // Show the style HUD
    public void showStyleHUD()
    {
        styleManager.isHUDActive = true;
        
        isStyleHUDActive = true;
        styleHUD.SetActive(true);
    }
    

}
