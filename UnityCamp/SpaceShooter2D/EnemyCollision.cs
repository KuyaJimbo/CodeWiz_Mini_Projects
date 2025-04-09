using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // -- MAKE SURE THE BULLET HAS A COLLIDER2D COMPONENT --
    // - Example: CircleCollider2D
    // - The IsTrigger property should be checked to allow for trigger events

    // -- MAKE SURE THE BULLET HAS A RIGIDBODY2D COMPONENT --
    // - Example: Rigidbody2D
    // - Set Gravity Scale = 0
    // - Collision Detection should be set to Continuous (more accurate for fast-moving objects)

    // Challenge 1: Create a PUBLIC enemyDestroyedSound variable (Data Type: AudioClip)
    // public AudioClip enemyDestroyedSound;

    /* -- ENTER YOUR CODE HERE -- */

    // Challenge 2: Play the enemyDestroyedSound when the enemy is destroyed
    // OnDestroy() is used when this object is destroyed
    private void OnDestroy()
    {
        // Here's how to play the explosion sound
        // Example: AudioSource.PlayClipAtPoint(enemyDestroyedSound, transform.position);

        /* -- ENTER YOUR CODE HERE -- */
    }
}
