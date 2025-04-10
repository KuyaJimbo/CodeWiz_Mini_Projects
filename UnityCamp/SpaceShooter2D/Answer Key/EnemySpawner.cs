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

    // Prefabs are pre-made game objects that we can use in our game.
    // Challenge 1: Create a PUBLIC ENEMYPREFAB variable (Data Type: GameObject)
    // Example: public GameObject enemyPrefab;

    /* -- ENTER YOUR CODE HERE -- */
    public GameObject enemyPrefab;

    // Rate of enemy spawn (in seconds)
    // Challenge 2: Create a PUBLIC enemySpawnRate variable (Data Type: float)
    // Example: public float enemySpawnRate;

    /* -- ENTER YOUR CODE HERE -- */
    public float enemySpawnRate;

    // Timer to keep track of when to spawn the next enemy
    // Challenge 3: Create a PRIVATE enemySpawnTimer variable (Data Type: float)
    // Example: private float enemySpawnTimer;

    /* -- ENTER YOUR CODE HERE -- */
    private float enemySpawnTimer;

    // Enemy Spawn X Position
    // Challenge 4: Create a PUBLIC enemySpawnX variable (Data Type: float)
    // Example: public float enemySpawnX;

    /* -- ENTER YOUR CODE HERE -- */
    public float enemySpawnX;

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
        if (enemySpawnRate == 0)
        {
            // Give a Default value
            enemySpawnRate = 2f;
        }


        // -- GIVE ENEMYSPAWNTIMER A DEFAULT VALUE --
        // if (enemySpawnTimer == 0)
        // {
        //     // Give a Default value
        //     enemySpawnTimer = 0f;
        // }

        /* -- ENTER YOUR CODE HERE -- */
        if (enemySpawnTimer == 0)
        {
            // Give a Default value
            enemySpawnTimer = 0f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        // --- CONTROL ENEMY SPAWN TIMER ---
        // Increase the enemy spawn timer by the time since the last frame
        // Example: enemySpawnTimer += Time.deltaTime;

        /* -- ENTER YOUR CODE HERE -- */
        enemySpawnTimer += Time.deltaTime;

        // --- CONTROL ENEMY SPAWN ---
        if (enemySpawnTimer >= enemySpawnRate)
        {
            // 1) Randomly select an enemySpawnX position for the enemy spawn
            // Example: enemySpawnX = Random.Range(-8f, 8f);

            /* -- ENTER YOUR CODE HERE -- */
            enemySpawnX = Random.Range(-8f, 8f);

            // 2) Spawn an enemy at the spawner's position 
            // INSTANTIATE creates a GAMEOBJECT at a POSITION with a ROTATION
            // Example: Instantiate(enemyPrefab, new Vector2(enemySpawnX, 6f), Quaternion.identity);

            /* -- ENTER YOUR CODE HERE -- */
            Instantiate(enemyPrefab, new Vector2(enemySpawnX, 6f), Quaternion.identity);

            // 3) Reset the enemy spawn timer
            // Example: enemySpawnTimer = 0f;

            /* -- ENTER YOUR CODE HERE -- */
            enemySpawnTimer = 0f;

            // 4) Decrease the enemy spawn rate (make it spawn faster)
            // Example: enemySpawnRate -= 0.1f; // Decrease spawn rate by 0.1 seconds

            /* -- ENTER YOUR CODE HERE -- */
            enemySpawnRate -= 0.1f; // Decrease spawn rate by 0.1 seconds


            // 5) BONUS Make sure the enemy spawn rate doesn't go below 0.5 seconds
            if (enemySpawnRate < 0.5f)
            {
                enemySpawnRate = 0.5f;
            }
        }


    }

}
