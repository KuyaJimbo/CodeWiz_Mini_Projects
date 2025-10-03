using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private int coinReward = 10;
    [SerializeField] private int damageToBase = 1;
    
    [Header("Visuals")]
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private bool flipSpriteBasedOnDirection = true;
    
    [Header("Pathfinding")]
    [SerializeField] private Transform[] waypoints;
    private int waypointIndex = 0;
    
    private int currentHealth;
    private Rigidbody2D rb;
    private Vector2 lastPosition;
    
    void Start()
    {
        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody2D>();
        lastPosition = transform.position;
        
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();
        
        if (waypoints.Length == 0)
        {
            GameObject waypointParent = GameObject.Find("Waypoints");
            if (waypointParent != null)
            {
                waypoints = waypointParent.GetComponentsInChildren<Transform>();
            }
        }
    }
    
    void Update()
    {
        Move();
        UpdateSpriteDirection();
    }
    
    void Move()
    {
        if (waypoints.Length == 0) return;
        
        Transform targetWaypoint = waypoints[waypointIndex];
        Vector2 direction = (targetWaypoint.position - transform.position).normalized;
        rb.velocity = direction * moveSpeed;
        
        if (Vector2.Distance(transform.position, targetWaypoint.position) < 0.2f)
        {
            waypointIndex++;
            
            if (waypointIndex >= waypoints.Length)
            {
                ReachEnd();
            }
        }
    }
    
    void UpdateSpriteDirection()
    {
        if (!flipSpriteBasedOnDirection || spriteRenderer == null) return;
        
        // Flip sprite based on movement direction
        Vector2 currentPosition = transform.position;
        if (currentPosition.x > lastPosition.x)
        {
            spriteRenderer.flipX = false; // Moving right
        }
        else if (currentPosition.x < lastPosition.x)
        {
            spriteRenderer.flipX = true; // Moving left
        }
        
        lastPosition = currentPosition;
    }
    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    
    public int GetCurrentHealth() { return currentHealth; }
    public int GetMaxHealth() { return maxHealth; }
    
    void Die()
    {
        ResourceManager.Instance.AddCoins(coinReward);
        Destroy(gameObject);
    }
    
    void ReachEnd()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.TakeDamage(damageToBase);
        }
        Destroy(gameObject);
    }
}