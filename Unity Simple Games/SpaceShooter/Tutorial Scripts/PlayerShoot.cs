using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    // HOW TO CREATE A VARIABLE:
    // Variables have 3 parts:
    // Access_Type: how we can access the variable (public/private)
    // Data_Type: what type of data the variable holds (int, float, string, etc.)
    // Variable_Name: the name of the variable (should be descriptive of what it does)

    // Prefabs are pre-made game objects that we can use in our game.
    // Challenge 1: Create a PUBLIC PROJECTILEPREFAB variable (Data Type: GameObject)

    /* -- ENTER YOUR CODE HERE -- */


    // Audio clips are sound files that we can play in our game.
    // Challenge 2: Create a PUBLIC shootSound variable (Data Type: AudioClip)
    // public AudioClip shootSound;

    /* -- ENTER YOUR CODE HERE -- */


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Inputs are the keys the player presses on the keyboard or controller
        // We can use the Input class to get the input values

        // --- CONTROL SHOOTING ---
        // Check if the player presses the space key
        // Hint: use Input.GetKeyDown(KeyCode.Space)

        // if (Input.__________(_______._____))
        // {
        //     // INSTANTIATE creates a GAMEOBJECT at a POSITION with a ROTATION
        //     Instantiate(____________, transform.position, Quaternion.identity);
        //
        //     // PLAYCLIPATPOINT plays an AUDIOCLIP at a specific position in the game world
        //     // AudioSource.PlayClipAtPoint(__________, transform.position);
        // }

    }
}
