using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [Header("Attack Settings")]
    public float knockbackForce = 10f;
    public AudioClip attackSound;
    
    private void OnCollisionEnter(Collision collision)
    {
        // Check if we collided with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Get player's rigidbody
            Rigidbody playerRb = collision.gameObject.GetComponent<Rigidbody>();
            
            if (playerRb != null)
            {
                // Calculate direction from enemy to player
                Vector3 knockbackDirection = (collision.transform.position - transform.position).normalized;
                
                // Apply force to push player back
                playerRb.AddForce(knockbackDirection * knockbackForce, ForceMode.Impulse);
                
                // Play attack sound
                // AudioSource.PlayClipAtPoint(attackSound, transform.position);
            }
        }
    }
}
