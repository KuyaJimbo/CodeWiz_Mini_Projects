using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // For SceneManager (Resetting the level)
using TMPro;  // For TextMeshProUGUI (UI Text)

public class GameManager : MonoBehaviour
{
    // HOW TO CREATE A VARIABLE:
    // Variables have 3 parts:
    // Access_Type: how we can access the variable (public/private)
    // Data_Type: what type of data the variable holds (int, float, string, etc.)
    // Variable_Name: the name of the variable (should be descriptive of what it does)

    // Challenge 1: Create a PUBLIC GAME OVER SCREEN UI variable (Data Type: GameObject)
    // Example: public GameObject gameOverScreenUI;

    /* -- ENTER YOUR CODE HERE -- */
    public GameObject gameOverScreenUI;

    // Challenge 2: Create a PUBLIC IS GAMEOVER variable (Data Type: bool)
    // Example: public bool isGameOver;

    /* -- ENTER YOUR CODE HERE -- */
    public bool isGameOver;

    // Challenge 3: Create a PUBLIC SCORE variable (Data Type: int)
    // Example: public int score;

    /* -- ENTER YOUR CODE HERE -- */
    public int score;

    // Challenge 4: Create a PUBLIC SCORETEXT (Data Type: TextMeshProUGUI)
    // Example: public TextMeshProUGUI scoreText;

    /* -- ENTER YOUR CODE HERE -- */
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        // -- GIVE ISGAMEOVER A FALSE DEFAULT VALUE -- 
        // Example: isGameOver = false;

        // isGameOver = false;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        // --- CHECK IF THE GAME IS OVER ---
        // IF the game is over, show the game over screen UI
        // ELSE, hide the game over screen UI
        // if (isGameOver)
        // {
        //     // Show the game over screen UI (true)
        //     gameOverScreenUI.SetActive(true);
        // }
        // else
        // {
        //     // Hide the game over screen UI (false)
        //     gameOverScreenUI.SetActive(false);
        // }

        /* -- ENTER YOUR CODE HERE -- */
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

        // -- UPDATE THE SCORE TEXT UI --
        // if (scoreText)
        // {
        //     // Update the score text UI with the current score
        //     scoreText.text = "Score: " + score.ToString();
        // }

        // /* -- ENTER YOUR CODE HERE -- */
        if (scoreText)
        {
            // Update the score text UI with the current score
            scoreText.text = "Score: " + score.ToString();
        }
    }

    // This Function Resets the Game
    public void ReplayLevel()
    {
        // Use scene management to reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}