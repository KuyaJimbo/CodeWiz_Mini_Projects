using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerCode : MonoBehaviour
{
    // References and settings
    public GameObject enemyPrefab;        // Drag your enemy prefab here in the Inspector
    public float spawnInterval = 2f;      // Time between enemy spawns
    public float minX = -8f;              // Minimum X position for spawning
    public float maxX = 8f;               // Maximum X position for spawning
    public float spawnY = 6f;             // Y position for spawning (top of screen)

    private float nextSpawnTime;          // Time tracker for next spawn

    // Start is called before the first frame update
    void Start()
    {
        // Set the first spawn time
        nextSpawnTime = Time.time + spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if it's time to spawn an enemy
        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            
            // Update the next spawn time
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    // Function to spawn an enemy at a random X position
    void SpawnEnemy()
    {
        // Generate a random X position within our boundaries
        float randomX = Random.Range(minX, maxX);
        
        // Create the spawn position
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0f);
        
        // Spawn the enemy
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
