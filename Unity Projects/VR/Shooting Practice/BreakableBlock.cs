using UnityEngine;

public class BreakableBlock : MonoBehaviour
{
    [Tooltip("Health points of the block")]
    public int health = 3;
    
    [Tooltip("Sound to play when the block is destroyed")]
    public AudioClip destroySound;
    public AudioClip hitSound;
    
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the "Projectile" tag
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // Destroy the Projectile
            Destroy(collision.gameObject);
            // Get the position before destroying for sound placement
            Vector3 position = transform.position;
            
            // Decrease health by 1
            // Example: health -= 1;
            health -= 1;

            // Play sound if available
            if (hitSound != null)
            {
                AudioSource.PlayClipAtPoint(hitSound, position);
            }
            
            // Check if health is zero or less
            if (health <= 0)
            {
                
                
                // Play sound if available
                if (destroySound != null)
                {
                    AudioSource.PlayClipAtPoint(destroySound, position);
                }
                
                // Destroy the game object
                // Example: Destroy(gameObject);
                Destroy(gameObject);
            }
        }
    }
}
