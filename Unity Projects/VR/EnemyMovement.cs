using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 3f;
    public float detectionRange = 10f;
    
    private Transform player;
    private Rigidbody rb;
    private bool playerDetected = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        
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
            Vector3 direction = (player.position - transform.position).normalized;
            
            // Move towards player
            rb.velocity = direction * moveSpeed;
            
            // Optional: rotate to face player
            if (direction != Vector3.zero)
            {
                Quaternion lookRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
            }
        }
        else
        {
            // Stop moving if player not detected
            rb.velocity = Vector3.zero;
        }
    }
    
    // Optional: Draw the detection range in the editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}
