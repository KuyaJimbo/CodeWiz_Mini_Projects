using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour
{
    // Enemy properties
    public float speed = 3f;            // Movement speed
    public int pointValue = 10;         // Points awarded for destroying this enemy
    
    // Reference to the player (optional)
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        // Find the player (optional - for targeting)
        player = GameObject.FindGameObjectWithTag("Player");
        
        // Make sure the enemy has the "Enemy" tag for bullet collision detection
        gameObject.tag = "Enemy";
    }

    // Update is called once per frame
    void Update()
    {
        // Move the enemy downward
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        
        // Destroy the enemy if it goes off-screen
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
    
    // Handle collision with player
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the enemy collides with the player
        if (other.CompareTag("Player"))
        {
            // Get the PlayerCode component from the player
            PlayerCode playerCode = other.GetComponent<PlayerCode>();
            
            // Decrease player lives or implement game over logic here
            
            // Destroy the enemy
            Destroy(gameObject);
        }
    }
}
