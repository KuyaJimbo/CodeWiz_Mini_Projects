using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // HOW TO CREATE A VARIABLE:
    // Variables have 3 parts:
    // Access_Type: how we can access the variable (public/private)
    // Data_Type: what type of data the variable holds (int, float, string, etc.)
    // Variable_Name: the name of the variable (should be descriptive of what it does)

    // Challenge 1: Create a List of SPAWNERS variable (Data Type: List<GameObject>)
    // Example: public List<GameObject> enemySpawners = new List<GameObject>();

    /* -- ENTER YOUR CODE HERE -- */
    public List<GameObject> enemySpawners = new List<GameObject>();

    // Challenge 2: Create a PUBLIC PLAYER SHIP PREFAB variable (Data Type: GameObject)
    // Example: public GameObject playerShipPrefab;

    /* -- ENTER YOUR CODE HERE -- */
    public GameObject playerShipPrefab;

    // Challenge 3: Create a PUBLIC TITLE SCREEN UI variable (Data Type: GameObject)
    // Example: public GameObject titleScreenUI;

    /* -- ENTER YOUR CODE HERE -- */
    public GameObject titleScreenUI;

    // Challenge 4: Create a PUBLIC GAME OVER SCREEN UI variable (Data Type: GameObject)
    // Example: public GameObject gameOverScreenUI;

    /* -- ENTER YOUR CODE HERE -- */
    public GameObject gameOverScreenUI;

    // Challenge 5: Create a PUBLIC IS GAME STARTED variable (Data Type: bool)
    // Example: public bool isGameStarted = false;

    /* -- ENTER YOUR CODE HERE -- */
    public bool isGameStarted = false;

    // Challenge 6: Create a PUBLIC IS GAME OVER variable (Data Type: bool)
    // Example: public bool isGameOver = false;

    /* -- ENTER YOUR CODE HERE -- */
    public bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the game state
        isGameStarted = false;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the game is started
        if (isGameStarted)
        {
            // Hide the title screen UI (false)
            titleScreenUI.SetActive(false);
        }
        else
        {
            // Show the title screen UI (true)
            titleScreenUI.SetActive(true);
        }

        // Check if the game is over
        if (isGameOver)
        {
            // Show the game over screen UI (true)
            gameOverScreenUI.SetActive(true);
        }
        else
        {
            // Hide the game over screen UI (false)
            gameOverScreenUI.SetActive(false);
        }
    }

    public void StartGame()
    {
        // Set the game started flag to true
        isGameStarted = true;

        // Set the game over flag to false
        isGameOver = false;

        // Add the player ship
        Instantiate(playerShipPrefab, new Vector3(0, -4, 0), Quaternion.identity);

        // Add each of the enemy spawners to the game
        foreach (GameObject enemySpawner in enemySpawners)
        {
            Instantiate(enemySpawner, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    public void ReplayLevel()
    {
        // Use scene management to reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}