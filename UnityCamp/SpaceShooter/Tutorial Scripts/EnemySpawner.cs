using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // HOW TO CREATE A VARIABLE:
    // Variables have 3 parts:
    // Access_Type: how we can access the variable (public/private)
    // Data_Type: what type of data the variable holds (int, float, string, etc.)
    // Variable_Name: the name of the variable (should be descriptive of what it does)

    // Timer to keep track of when to spawn the next enemy
    private float enemySpawnTimer;

    // Rate of enemy spawn (in seconds)
    public float enemySpawnRate;


    // Prefabs are pre-made game objects that we can use in our game.
    // Challenge 1: Create a PUBLIC enemyPrefab variable (Data Type: GameObject)
    // Example: public GameObject enemyPrefab;

    /* -- ENTER YOUR CODE HERE -- */


    // BoostSpawnRate is how much faster we spawn as the game progresses
    // Challenge 2: Create a PUBLIC boostSpawnRate variable (Data Type: float)
    // Example: public float boostSpawnRate;

    /* -- ENTER YOUR CODE HERE -- */


    // Enemy Spawn X Position
    // Challenge 3: Create a PUBLIC enemySpawnX variable (Data Type: float)
    // Example: public float enemySpawnX;

    /* -- ENTER YOUR CODE HERE -- */


    // Give the Enemy an angle to spawn at
    // Challenge 4: Create a PUBLIC enemySpawnAngle variable (Data Type: float)
    // Example: public float enemySpawnAngle;

    /* -- ENTER YOUR CODE HERE -- */


    // Start is called before the first frame update
    void Start()
    {
        // -- GIVE ENEMYSPAWNRATE A DEFAULT VALUE --
        // if (enemySpawnRate == 0)
        // {
        //     // Give a Default value
        //     enemySpawnRate = 2f;
        // }

        /* -- ENTER YOUR CODE HERE -- */


        // -- GIVE ENEMYSPAWNTIMER A DEFAULT VALUE --
        // if (enemySpawnTimer == 0)
        // {
        //     // Give a Default value
        //     enemySpawnTimer = 0f;
        // }

        /* -- ENTER YOUR CODE HERE -- */


        // -- GIVE BOOSTSPAWNRATE A DEFAULT VALUE --
        // if (boostSpawnRate == 0)
        // {
        //     // Give a Default value
        //     boostSpawnRate = 0.1f;
        // }

        /* -- ENTER YOUR CODE HERE -- */

    }

    // Update is called once per frame
    void Update()
    {
        // --- CONTROL ENEMYSPAWNTIMER ---
        // Increase the enemy spawn timer by the time since the last frame
        enemySpawnTimer += Time.deltaTime;

        // --- CONTROL ENEMY SPAWN ---
        if (enemySpawnTimer >= enemySpawnRate)
        {
            // 1) Randomly select an enemySpawnX position for the enemy spawn
            // Example: enemySpawnX = Random.Range(-8f, 8f);

            /* -- ENTER YOUR CODE HERE -- */


            // 2) Randomly select an enemySpawnAngle for the enemy spawn
            // Example: enemySpawnAngle = Random.Range(-15f, 15f);

            /* -- ENTER YOUR CODE HERE -- */


            // 3) Spawn an enemy at the spawner's position 
            // INSTANTIATE creates a GAMEOBJECT at a POSITION with a ROTATION (with enemySpawnAngle)
            // Example: Instantiate(enemyPrefab, new Vector2(enemySpawnX, 6f), Quaternion.Euler(0, 0, enemySpawnAngle));

            /* -- ENTER YOUR CODE HERE -- */


            // 4) Reset the enemy spawn timer
            // Example: enemySpawnTimer = 0f;

            /* -- ENTER YOUR CODE HERE -- */


            // 5) Decrease the enemy spawn rate (make it spawn faster) using BoostSpawnRate
            // Example: enemySpawnRate *= (1 - (boostSpawnRate));
            
            /* -- ENTER YOUR CODE HERE -- */


            // 6) BONUS Make sure the enemy spawn rate doesn't go below 0.5 seconds


        }
    }
}