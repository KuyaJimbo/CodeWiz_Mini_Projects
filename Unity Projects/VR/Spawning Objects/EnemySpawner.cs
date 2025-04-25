using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject enemyPrefab;
    public Transform spawnPosition;
    public float spawnInterval = 3f;
    public int maxEnemies = 10;
    public AudioClip spawnSound;
    
    private int currentEnemyCount = 0;
    private bool isSpawning = false;
    
    void Start()
    {
        // If no spawn position is set, use this object's position
        if (spawnPosition == null)
        {
            spawnPosition = transform;
        }
        
        // Start the spawning coroutine
        StartCoroutine(SpawnEnemies());
    }
    
    IEnumerator SpawnEnemies()
    {
        isSpawning = true;
        
        while (isSpawning)
        {
            // Check if we haven't reached the maximum number of enemies
            if (currentEnemyCount < maxEnemies)
            {
                // Spawn the enemy
                GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition.position, spawnPosition.rotation);
                
                // Play spawn sound
                // if (spawnSound != null)
                // {
                //     AudioSource.PlayClipAtPoint(spawnSound, spawnPosition.position);
                // }
                
                // Increment the enemy count
                currentEnemyCount++;
            }
            
            // Wait for the specified interval
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    
    // Call this when an enemy is destroyed to decrease the count
    public void EnemyDestroyed()
    {
        if (currentEnemyCount > 0)
        {
            currentEnemyCount--;
        }
    }
    
    // Stop spawning when this object is destroyed
    void OnDestroy()
    {
        isSpawning = false;
    }
}
