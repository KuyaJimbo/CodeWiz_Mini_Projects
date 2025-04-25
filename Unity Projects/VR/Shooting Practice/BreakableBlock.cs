using UnityEngine;

public class BreakableBlock : MonoBehaviour
{
    [Tooltip("Health points of the block")]
    public int health = 3;
    
    [Tooltip("Sound to play when the block is destroyed")]
    public AudioClip destroySound;
    
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the "Projectile" tag
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // Decrease health by 1
            // Example: health -= 1;
            
            // Check if health is zero or less
            if (health <= 0)
            {
                // Get the position before destroying for sound placement
                Vector3 position = transform.position;
                
                // Play sound if available
                if (destroySound != null)
                {
                    AudioSource.PlayClipAtPoint(destroySound, position);
                }
                
                // Destroy the game object
                // Example: Destroy(gameObject);
            }
        }
    }
}