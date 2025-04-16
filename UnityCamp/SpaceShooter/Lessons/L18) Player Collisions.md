# L18) Player Collisions

When the Player collides with an Enemy, GAME OVER!

## Add the Enemy Collisions Script to the Player Object

1. Select the **Player Object** in the **Scene**
2. Click **Add Component** in the **Inspector**
3. Select the **Player Collision** Script

## Open the Script and Fix the Code!

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class PlayerCollision : MonoBehaviour

{

### // Challenge 1: Create a PUBLIC gameOverSound variable (Data Type: AudioClip)
    public AudioClip gameOverSound;

### // Fix the OnTriggerEnter2D Function so it detects the Enemy!
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the bullet collides with an enemy object
        if (collision.CompareTag("Enemy"))
        {
            // Challenge 2: Get the GameManager
            GameManager gameManager = FindObjectOfType<GameManager>();

            // Challenge 3: Set the game over state in the GameManager
            if (gameManager)
            {
                // Example: gameManager.isGameOver = true;
                gameManager.isGameOver = true;
            }

            // Challenge 4: Play the gameOverSound when the player is destroyed
            if (gameOverSound)
            {
                AudioSource.PlayClipAtPoint(gameOverSound, transform.position);
            }

            // Challenge 5: Destroy this player object
            Destroy(gameObject);
        }
    }
}


## The Projectile needs a PolygonCollider2D so it knows when it hits something else

1. Select the **Projectile Object** in the **Scene**

2. Click **Add Component** in the **Inspector**
3. Select the **PolygonCollider2D** component
4. Check the **IsTrigger** Property

## The Projectile needs a RigidBody2D so it knows when it hits something else

1. Select the **Projectile Object** in the **Scene**

2. Click **Add Component** in the **Inspector**
3. Select the **PolygonCollider2D** component
4. Set **Gravity Scale** = 0
5. Set **Collision Detection** = Continuous

## Now test out your game by clicking the Play Button


## Projectile needs an Enemy Destroyed Sound!

There should be a folder called **Sounds** in the **Project Files**.

Select a sound and press the Play button in the Inspector to hear it.

1) Select the **Player** Object in Unity

2) Look for the **Player Collision** Script in the **Inspector** and find the **enemyDestroyedSound** field
2) Click and Drag your **Sound** and into the **gameOverSound** field 

## Now test out your game by clicking the Play Button

Shoot down the Enemies!

# Want more Sounds?

You can find a whole library of Sound Files on https://scratch.mit.edu/

1) Navigate to the **Sounds Library**

    Create Button > Sounds Tab > Choose a Sound Button

2) Select a Sound and Export it
    
    **Right-Click** on the sound and select **export**

3) Reopen **Unity** and **Right-Click** in the **Project Files** section at the bottom of your screen.
4) Click **Import New Asset...**
5) Open the **Download Folder**, select your **sound**, and click **Import**