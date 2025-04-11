using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [Header("Attack Settings")]
    public float knockbackForce = 10f;
    public AudioClip attackSound;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if we collided with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Get player's rigidbody
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();
            
            if (playerRb != null)
            {
                // Calculate direction from enemy to player
                Vector2 knockbackDirection = (collision.transform.position - transform.position).normalized;
                
                // Apply force to push player back
                playerRb.AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);
                
                // Play attack sound
                // AudioSource.PlayClipAtPoint(attackSound, transform.position);
            }
        }
    }
}
