# L14) Game Manager

This tutorial demonstrates how to create a Game Manager Object in Unity

## Use an Empty Game Object for the Player

1. In the **Hierarchy**, add an Empty Game Object and name it "Game Manager"

- Create Empty

## Add the Enemy Spawner Script to the Empty Object

1. Select the **Game Manager Object** in the **Scene**

2. Click **Add Component** in the **Inspector**
3. Select the **Game Manager** Script

## Open the Script and Fix the Code!

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;  // For SceneManager (Resetting the level)

using TMPro;  // For TextMeshProUGUI (UI Text)

public class GameManager : MonoBehaviour

{

### // HOW TO CREATE A VARIABLE:

// Variables have 3 parts:

// **Access_Type**: how we can access the variable (public/private)

// **Data_Type**: what type of data the variable holds (int, float, string, etc.)

// **Variable_Name**: the name of the variable (should be descriptive of what it does)

### // PUBLIC SCORE variable (Data Type: int)
    public int score;

### // Challenge 1: Create a PUBLIC GAME OVER SCREEN UI variable (Data Type: GameObject)
    public GameObject gameOverScreenUI;

### // Challenge 2: Create a PUBLIC IS GAMEOVER variable (Data Type: bool)
    public bool isGameOver;

### // Challenge 3: Create a PUBLIC SCORETEXT (Data Type: TextMeshProUGUI)
    public TextMeshProUGUI scoreText;

### // Start is called before the first frame update
    void Start()
    {
        // -- GIVE ISGAMEOVER A FALSE DEFAULT VALUE -- 
        isGameOver = false;
    }

### // Update is called once per frame
    void Update()
    {
        // --- CHECK IF THE GAME IS OVER ---
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
        if (scoreText)
        {
            // Update the score text UI with the current score
            scoreText.text = "Score: " + score.ToString();
        }
    }

    public void ReplayLevel()
    {
        // Use scene management to reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

## Play test the game and make sure the only error isa missing gameOverScreenUI

Don't worry we'll fix this in the next lesson!