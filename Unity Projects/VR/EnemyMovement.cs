using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 3f;
    public float detectionRange = 10f;
    
    private Transform player;
    private Rigidbody2D rb;
    private bool playerDetected = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Find the player by tag
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }
    
    void Update()
    {
        // Check if we have a reference to the player
        if (player == null)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if (playerObject != null)
            {
                player = playerObject.transform;
            }
            else
            {
                return;
            }
        }
        
        // Calculate distance to player
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        
        // Check if player is within detection range
        if (distanceToPlayer <= detectionRange)
        {
            playerDetected = true;
        }
        else
        {
            playerDetected = false;
        }
    }
    
    void FixedUpdate()
    {
        if (playerDetected && player != null)
        {
            // Get direction to player
            Vector2 direction = (player.position - transform.position).normalized;
            
            // Move towards player
            rb.velocity = direction * moveSpeed;
            
            // Optional: rotate to face player
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = angle;
        }
        else
        {
            // Stop moving if player not detected
            rb.velocity = Vector2.zero;
        }
    }
    
    // Optional: Draw the detection range in the editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}
