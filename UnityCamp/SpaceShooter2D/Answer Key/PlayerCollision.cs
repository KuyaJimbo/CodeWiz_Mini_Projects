using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // -- MAKE SURE THE PLAYER HAS A COLLIDER2D COMPONENT --
    // - Example: CircleCollider2D
    // - The IsTrigger property should be checked to allow for trigger events

    // -- MAKE SURE THE PLAYER HAS A RIGIDBODY2D COMPONENT --
    // - Example: Rigidbody2D
    // - Set Gravity Scale = 0
    // - Collision Detection should be set to Continuous (more accurate for fast-moving objects)

    // --- COLLISION DETECTION ---
    // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
    // We can use Tags to identify the object we are colliding with

    // Challenge 1: Create a PUBLIC gameOverSound variable (Data Type: AudioClip)
    // Example: public AudioClip gameOverSound;

    /* -- ENTER YOUR CODE HERE -- */
    public AudioClip gameOverSound;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the bullet collides with an enemy
        if (collision.CompareTag("Enemy"))
        {
            // 1) Play the enemyDestroyedSound when the enemy is destroyed
            // Example: AudioSource.PlayClipAtPoint(enemyDestroyedSound, transform.position);

            /* -- ENTER YOUR CODE HERE -- */
            AudioSource.PlayClipAtPoint(gameOverSound, transform.position);

            // 2) Get the GameManager
            // Example: GameManager gameManager = FindObjectOfType<GameManager>();

            /* -- ENTER YOUR CODE HERE -- */
            GameManager gameManager = FindObjectOfType<GameManager>();

            // 3) Set the game over state in the GameManager
            // Example: gameManager.isGameOver = true;

            /* -- ENTER YOUR CODE HERE -- */
            gameManager.isGameOver = true;

            // 4) Destroy this player object
            // Example: Destroy(gameObject);

            /* -- ENTER YOUR CODE HERE -- */
            Destroy(gameObject);
        }
    }
}
