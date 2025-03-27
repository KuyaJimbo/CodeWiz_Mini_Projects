using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour
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
}
