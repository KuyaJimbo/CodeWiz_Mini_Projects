# L13) Enemy Spawners

This tutorial demonstrates how to create a Game Object Spawner in Unity

## Use an Empty Game Object for the Player

1. In the **Hierarchy**, add an Empty Game Object and name it "Enemy Spawner"

- Create Empty

## Add the Enemy Spawner Script to the Empty Object

1. Select the **Enemy Spawner Object** in the **Scene**

2. Click **Add Component** in the **Inspector**

3. Select the **Enemy Spawner** Script

## Open the Script and Fix the Code!

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class EnemySpawner : MonoBehaviour

{

### // HOW TO CREATE A VARIABLE:

// Variables have 3 parts:

// **Access_Type**: how we can access the variable (public/private)

// **Data_Type**: what type of data the variable holds (int, float, string, etc.)

// **Variable_Name**: the name of the variable (should be descriptive of what it does)

// Timer to keep track of when to spawn the next enemy

    private float enemySpawnTimer;

// Rate of enemy spawn (in seconds)
    
    public float enemySpawnRate;


### // Challenge 1: Create a PUBLIC enemyPrefab variable (Data Type: GameObject)

    public GameObject enemyPrefab;


### // Challenge 2: Create a PUBLIC boostSpawnRate variable (Data Type: float)

    public float boostSpawnRate;

### // Challenge 3: Create a PUBLIC enemySpawnX variable (Data Type: float)

    public float enemySpawnX;

### // Challenge 4: Create a PUBLIC enemySpawnAngle variable (Data Type: float)

    public float enemySpawnAngle;

### // Start is called before the first frame update
    void Start()
    {
        // -- GIVE ENEMYSPAWNRATE A DEFAULT VALUE --
        if (enemySpawnRate == 0)
        {
            // Give a Default value
            enemySpawnRate = 2f;
        }


        // -- GIVE ENEMYSPAWNTIMER A DEFAULT VALUE --
        if (enemySpawnTimer == 0)
        {
            // Give a Default value
            enemySpawnTimer = 0f;
        }


        // -- GIVE BOOSTSPAWNRATE A DEFAULT VALUE --
        if (boostSpawnRate == 0)
        {
            // Give a Default value
            boostSpawnRate = 0.1f;
        }
    }

### // Update is called once per frame
    void Update()
    {
        // --- CONTROL ENEMYSPAWNTIMER ---
        // Increase the enemy spawn timer by the time since the last frame
        enemySpawnTimer += Time.deltaTime;

        // --- CONTROL ENEMY SPAWN ---
        if (enemySpawnTimer >= enemySpawnRate)
        {
            // 1) Randomly select an enemySpawnX position for the enemy spawn
            enemySpawnX = Random.Range(-8f, 8f);

            // 2) Randomly select an enemySpawnAngle for the enemy spawn
            enemySpawnAngle = Random.Range(-15f, 15f);

            // 3) Spawn an enemy at the spawner's position 
            // INSTANTIATE creates a GAMEOBJECT at a POSITION with a ROTATION (with 
            Instantiate(enemyPrefab, new Vector2(enemySpawnX, 6f), Quaternion.identity + Quaternion.Euler(0, 0, enemySpawnAngle));

            // 4) Reset the enemy spawn timer
            enemySpawnTimer = 0f;

            // 5) Decrease the enemy spawn rate (make it spawn faster) using BoostSpawnRate
            enemySpawnRate *= (1 - (boostSpawnRate));

            // 6) BONUS Make sure the enemy spawn rate doesn't go below 0.5 seconds
            enemySpawnRate = Mathf.Max(enemySpawnRate, 0.5f);

        }
    }
}

## Go back to Unity and adjust the PARAMETERS of this Enemy Spawner

1) Click and Drag any Enemy Prefab which you would like to Spawn

2) Set the Enemy Spawn Rate (How many seconds before one of these enemy's spawn?)

3) Set the Boost Spawn Rate (How much faster do they spawn over time?)

## Now test out your game by clicking the Play Button

Feel free to experiment with the Parameters

Remember, you can make MANY types of spawners if you make it a PREFAB