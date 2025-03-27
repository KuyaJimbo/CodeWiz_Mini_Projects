using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Make sure you have the following components attached to the player GameObject:
/// - Rigidbody2D
/// - BoxCollider2D
/// - SpriteRenderer
/// - Animator with the following parameters:
///    - A_Jump (Trigger)
///    - A_Run (Float)
///    - A_Attack (Trigger)
/// </summary>

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    // Private variables
    private bool isGrounded;
    private Rigidbody2D rb;                 // FOR PHYSICS
    private SpriteRenderer spriteRenderer;  // FOR FLIPPING SPRITE
    private Animator animator;              // FOR ANIMATIONS

    void Start()
    {
        isGrounded = false;
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Handle horizontal movement
        float moveInput = Input.GetAxis("Horizontal");

        // Change sprite direction based on movement
        if (moveInput > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        // Set A_Run parameter in animator
        animator.SetFloat("A_Run", Mathf.Abs(moveInput));

        // Apply velocity to the rigidbody
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Handle jumping if on ground
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

            // set A_Jump Trigger
            animator.SetTrigger("A_Jump");

        }

        // Handle attack if left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("A_Attack");
        }
    }

    // Check collisions with objects tagged "ground"
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    // Use trigger collisions for Coins and Enemies
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            // Pick up coin by destroying the coin object
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Enemy"))
        {
            // Reset the current level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
