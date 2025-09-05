using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Complete2DPlayerController : MonoBehaviour
{
    [Header("Player Movement")]
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    [Header("Player Abilities")]
    public bool canDoubleJump = false;
    public bool canSprint = false;

    [Header("Player Ability Variables")]
    public int jumpCount = 2;
    public float sprintMultiplier = 1.5f;

    [Header("Player Components")]
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    [Header("Player Sounds")]
    public AudioClip coinSound;
    public AudioClip jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Handle Player Movement
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Handle Player Jumping (Space)
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount > 0)
        {
            // Add Jump Force to the Rigidbody2D
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jumpCount--;
            if (jumpSound)
            {
                AudioSource.PlayClipAtPoint(jumpSound, transform.position);
            }
        }

        // Handle Player Sprinting (Left Shift)
        if (canSprint)
        {
            // Handle Player Sprinting
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity = new Vector2(moveInput * moveSpeed * sprintMultiplier, rb.velocity.y);
            }
        }
        else
        {
            // Handle Normal Movement
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }

        // Handle Player Facing Direction
        if (moveInput > 0)
        {
            sr.flipX = false; // Face right
        }
        else if (moveInput < 0)
        {
            sr.flipX = true; // Face left
        }
    }

    // OnCollisionEnter2D is called when the collider attached to this GameObject collides with another collider
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Reset Jump Count on Ground Collision
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (canDoubleJump)
            {
                jumpCount = 2;
            }
            else
            {
                jumpCount = 1;
            }
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            // Play Coin Collection Sound then Destroy the Coin
            if (coinSound)
            {
                AudioSource.PlayClipAtPoint(coinSound, transform.position);
            }
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            // Reset Current Scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (other.gameObject.CompareTag("Flag"))
        {
            // Load Level Menu Scene
            SceneManager.LoadScene("Level Menu");
        }

    }
}
