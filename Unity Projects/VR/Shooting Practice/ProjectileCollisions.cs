using UnityEngine;

public class ProjectileCollisions : MonoBehaviour
{
    [Header("Collision Settings")]
    public float projectileLifetime = 5f;
    public AudioClip impactSound;
    
    void Start()
    {
        // Destroy the projectile after a certain time if it doesn't hit anything
        Destroy(gameObject, projectileLifetime);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        HandleCollision(collision.gameObject);
    }
    
    private void OnTriggerEnter(Collider collider)
    {
        HandleCollision(collider.gameObject);
    }
    
    private void HandleCollision(GameObject collidedObject)
    {
        // Check if we hit an enemy
        if (collidedObject.CompareTag("Enemy"))
        {
            // Play impact sound
            // if (impactSound != null)
            // {
            //     AudioSource.PlayClipAtPoint(impactSound, transform.position);
            // }
            
            // Destroy the enemy
            Destroy(collidedObject);
            
            // Destroy the projectile
            Destroy(gameObject);
        }
        // Check if we hit a spawner
        else if (collidedObject.CompareTag("Spawner"))
        {
            // Play impact sound
            // if (impactSound != null)
            // {
            //     AudioSource.PlayClipAtPoint(impactSound, transform.position);
            // }
            
            // Notify the spawner that an enemy was destroyed (optional)
            EnemySpawner spawner = collidedObject.GetComponent<EnemySpawner>();
            if (spawner != null)
            {
                spawner.EnemyDestroyed();
            }
            
            // Destroy the spawner
            Destroy(collidedObject);
            
            // Destroy the projectile
            Destroy(gameObject);
        }
    }
}
