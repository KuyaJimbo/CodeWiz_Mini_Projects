using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn; // The object to spawn
    public float spawnInterval = 2f; // Time interval between spawns
    private float timer = 0f; // Timer to track time since last spawn

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the timer
        timer = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Check if it's time to spawn a new object
        if (timer >= spawnInterval)
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            // Reset the timer

        }
    }
}
