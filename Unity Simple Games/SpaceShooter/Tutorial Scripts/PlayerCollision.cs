using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // -- MAKE SURE THE PLAYER HAS A POLYGON COLLIDER2D COMPONENT --
    // - The IsTrigger property should be checked to allow for trigger events

    // -- MAKE SURE THE PLAYER HAS A RIGIDBODY2D COMPONENT --
    // - Example: Rigidbody2D
    // - Set Gravity Scale = 0
    // - Collision Detection should be set to Continuous (more accurate for fast-moving objects)

    // Challenge 1: Create a PUBLIC gameOverSound variable (Data Type: AudioClip)
    // Example: public AudioClip gameOverSound;

    /* -- ENTER YOUR CODE HERE -- */


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the bullet collides with an enemy object
        if (collision.CompareTag("Enemy"))
        {
            // Challenge 2: Get the GameManager
            // Example: GameManager gameManager = FindObjectOfType<GameManager>();

            /* -- ENTER YOUR CODE HERE -- */


            // Challenge 3: Set the game over state in the GameManager
            // if (gameManager)
            // {
            //     gameManager.isGameOver = true;
            // }

            /* -- ENTER YOUR CODE HERE -- */


            // Challenge 4: Play the gameOverSound when the player is destroyed
            // if (gameOverSound)
            // {
            //     AudioSource.PlayClipAtPoint(gameOverSound, transform.position);
            // }

            /* -- ENTER YOUR CODE HERE -- */


            // Challenge 5: Destroy this player object
            // Example: Destroy(gameObject);

            /* -- ENTER YOUR CODE HERE -- */

        }
    }
}
