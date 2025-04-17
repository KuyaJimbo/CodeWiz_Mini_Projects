# L10) Projectiles Collide

## Add the Projectile Movement Script to the Projectile Prefab

1. Select the **Projectile Prefab** in the **Scene**
2. Click **Add Component** in the **Inspector**
3. Select the **Projectile Collision** Script

## Open the Script and Fix the Code!

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class ProjectileCollision : MonoBehaviour

{

### // Challenge 1: Create a PUBLIC enemyDestroyedSound variable (Data Type: AudioClip)

    public AudioClip enemyDestroyedSound;

### // OnTriggerEnter2D is called when this object enters another object's Collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the projectile collides with an enemy object
        if (collision.CompareTag("Enemy"))
        {
            // Challenge 2: Play the enemyDestroyedSound when the enemy is destroyed
            // Play the enemyDestroyedSound when the enemy is destroyed
            AudioSource.PlayClipAtPoint(enemyDestroyedSound, transform.position);


            // Get the GameManager 
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager)
            {
                // Increase the score by 1
                gameManager.score += 1;
            }

            // Challenge 3: Destroy the enemy object
            Destroy(collision.gameObject);


            // Challenge 4: Destroy this bullet object
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

## Projectile needs an Enemy Destroyed Sound!

There should be a folder called **Sounds** in the **Project Files**.

Select a sound and press the Play button in the Inspector to hear it.

1) Select the **Player** Object in Unity

2) Look for the **Player Collision** Script in the **Inspector** and find the **enemyDestroyedSound** field

3) Click and Drag your **Sound** and into the **enemyDestroyedSound** field 

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