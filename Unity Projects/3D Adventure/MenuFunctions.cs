using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFunctions : MonoBehaviour
{
    // PUBLIC Pause Menu (Hint: GameObject)
    

    void Start()
    {
        // Hide the pause menu at the start of the game
        // pauseMenu.SetActive(false);


    }

    public void TogglePauseMenu()
    {
        if (Time.timeScale == 1f)
        {
            // Debug
            Debug.Log("Pausing the game");
            // Show the pause menu
            

        }
        else
        {
            // Debug
            Debug.Log("Resuming the game");

            // Hide the pause menu

        }
    }






}
