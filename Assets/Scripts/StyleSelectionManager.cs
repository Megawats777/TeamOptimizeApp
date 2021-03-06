﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StyleSelectionManager : MonoBehaviour
{
    /*--The Style Gameobjects--*/
    public GameObject businessStyle;

    public GameObject loungeStyle;

    public GameObject entertainmentStyle;
    public GameObject styleHUD;
    public bool isHUDActive = true;

    bool isInPerspectiveMode = false;

    // Use this for initialization
    void Start ()
    {
        // Disable all the styles at start
        clearAllStyles();
    }

    // Update is called once per frame
    void Update ()
    {
	
	}

    // Go back to the main menu
    public void returnToMenu()
    {
        SceneManager.LoadSceneAsync("M_Level_Menu");
    }
    
    // Open the business style
    public void openBusinessStyle()
    {
        // Enable the business style
        businessStyle.SetActive(true);

        // Disable the other styles
        loungeStyle.SetActive(false);
        entertainmentStyle.SetActive(false);
    }

    // Open the lounge style
    public void openLoungeStyle()
    {
        // Enable the lounge style
        loungeStyle.SetActive(true);

        // Disable the other styles
        businessStyle.SetActive(false);
        entertainmentStyle.SetActive(false);
    }

    // Open the entertainment style
    public void openEntertainmentStyle()
    {
        // Enable the entertainment style
        entertainmentStyle.SetActive(true);

        // Disable the other styles
        businessStyle.SetActive(false);
        loungeStyle.SetActive(false);
    }

    // Remove all styles
    public void clearAllStyles()
    {
        entertainmentStyle.SetActive(false);
        loungeStyle.SetActive(false);
        businessStyle.SetActive(false);
    }

    // Hide or show style selction HUD
    public void controlHUDVisibility()
    {
        if (isHUDActive == true)
        {
            isHUDActive = false;
            styleHUD.SetActive(false);
        }
        else if (isHUDActive == false)
        {
            isHUDActive = true;
            styleHUD.SetActive(true);
        }
    }

    // Hide the style HUD
    public void hideStyleHUD()
    {
        isHUDActive = false;
        styleHUD.SetActive(false);
    }

    // Exit the program
    public void exitProgram()
    {
        Application.Quit();
    }
}
