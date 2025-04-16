using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    // -- MAKE SURE THE PROJECTILE HAS A POLYGON COLLIDER2D COMPONENT -- (For trigger events)
    // - The IsTrigger property should be checked to allow for trigger events

    // -- MAKE SURE THE PROJECTILE HAS A RIGIDBODY2D COMPONENT -- (For physics interactions)
    // - Set Gravity Scale = 0
    // - Collision Detection should be set to Continuous (more accurate for fast-moving objects)

    // Challenge 1: Create a PUBLIC enemyDestroyedSound variable (Data Type: AudioClip)
    // public AudioClip enemyDestroyedSound;

    /* -- ENTER YOUR CODE HERE -- */


    // OnTriggerEnter2D is called when this object enters another object's trigger collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the projectile collides with an enemy
        if (collision.CompareTag("Enemy"))
        {
            // Challenge 2: Play the enemyDestroyedSound when the enemy is destroyed
            // Play the enemyDestroyedSound when the enemy is destroyed
            // Example: AudioSource.PlayClipAtPoint(enemyDestroyedSound, transform.position);

            /* -- ENTER YOUR CODE HERE -- */


            // Get the GameManager 
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager)
            {
                // Increase the score by 1
                gameManager.score += 1;
            }

            // Challenge 3: Destroy the enemy object
            // Example: Destroy(collision.gameObject);

            /* -- ENTER YOUR CODE HERE -- */



            // Challenge 4: Destroy this bullet object
            // Example: Destroy(gameObject);

        }
    }
}