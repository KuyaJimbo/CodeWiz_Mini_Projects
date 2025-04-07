using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Make sure to have the following components:
// 1. Rigidbody2D (with Gravity Scale set to 0)
// 2. BoxCollider2D (or any other collider that fits your player shape)
// 3. SpriteRenderer (to display the player sprite)

public class BulletCode : MonoBehaviour
{
    // Access_Type  Data_Type   Variable_Name;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f; // Set the speed to a default value
    }

    // Update is called once per frame
    void Update()
    {
        // Move the bullet forward at the specified speed
        // transform.Translate(_______.__ * _____ * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bullet collides with an enemy
        if (other.CompareTag("Enemy"))
        {
            // Destroy the enemy and the bullet
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        // Check if the bullet collides with a wall or obstacle
        else if (other.CompareTag("Wall"))
        {
            // Destroy the bullet
            Destroy(gameObject);
        }
    }
}
