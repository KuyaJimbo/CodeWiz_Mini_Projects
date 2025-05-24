using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFunctions : MonoBehaviour
{
    // Change the scene
    public void ChangeScene(string sceneName)
    {
        // Debug 
        Debug.Log("Changing scene to " + sceneName);
        SceneManager.LoadScene(sceneName);
    }

    // Reset the scene
    public void ResetScene()
    {
        // Debug
        Debug.Log("Resetting the scene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Pause the game
    public void PauseGame()
    {
        // Debug
        Debug.Log("Pausing the game");
        Time.timeScale = 0f; // Pause the game
    }
    // Resume the game
    public void ResumeGame()
    {
        // Debug
        Debug.Log("Resuming the game");
        Time.timeScale = 1f; // Resume the game
    }

    public void TogglePause()
    {
        // Debug
        Debug.Log("Toggling pause");
        // Create an IF-ELSE statement to check if the game is paused,
        // if it is, resume the game, otherwise pause the game
        
    }


}
