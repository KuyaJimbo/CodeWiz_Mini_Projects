using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    // -- MAKE SURE THE BULLET HAS A COLLIDER2D COMPONENT -- (For trigger events)
    // Example: CircleCollider2D
    // - The IsTrigger property should be checked to allow for trigger events

    // -- MAKE SURE THE BULLET HAS A RIGIDBODY2D COMPONENT -- (For physics interactions)
    // - Set Gravity Scale = 0
    // - Collision Detection should be set to Continuous (more accurate for fast-moving objects)


    // --- COLLISION DETECTION ---
    // OnTriggerEnter2D is used when the Collider2D other enters the trigger (2D physics only)
    // We can use Tags to identify the object we are colliding with


    // Challenge 1: Create a PUBLIC enemyDestroyedSound variable (Data Type: AudioClip)
    // public AudioClip enemyDestroyedSound;

    /* -- ENTER YOUR CODE HERE -- */
    public AudioClip enemyDestroyedSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the bullet collides with an enemy
        if (collision.CompareTag("Enemy"))
        {
            // Challenge 2: Play the enemyDestroyedSound when the enemy is destroyed
            // Play the enemy destroyed sound at the enemy's position
            AudioSource.PlayClipAtPoint(enemyDestroyedSound, transform.position);

            // Destroy the enemy object
            Destroy(collision.gameObject);

            // Destroy this bullet object
            Destroy(gameObject);
        }
    }
}