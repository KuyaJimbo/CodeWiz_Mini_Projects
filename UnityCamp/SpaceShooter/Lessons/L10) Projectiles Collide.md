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

## Now test out your game by clicking the Play Button

Shoot down the Enemies!