using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 15f;
    
    [Header("Ground Check")]
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius = 0.2f;
    [SerializeField] private LayerMask groundLayer;
    
    [Header("Visuals")]
    [SerializeField] private SpriteRenderer spriteRenderer;
    
    private Rigidbody2D rb;
    private Animator animator; // Add this
    private bool isGrounded;
    private float horizontalInput;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); // Get animator if exists
        
        // Get sprite renderer if not assigned
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        
        // Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        
        // Handle sprite flipping
        FlipSprite();
        
        // Update animations if animator exists
        UpdateAnimations();
    }
    
    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
    }
    
    void FlipSprite()
    {
        if (horizontalInput > 0)
        {
            spriteRenderer.flipX = false; // Face right
        }
        else if (horizontalInput < 0)
        {
            spriteRenderer.flipX = true; // Face left
        }
    }
    
    void UpdateAnimations()
    {
        if (animator == null) return;
        
        // Set animator parameters
        animator.SetFloat("Speed", Mathf.Abs(horizontalInput));
        animator.SetBool("IsGrounded", isGrounded);
        animator.SetFloat("VelocityY", rb.velocity.y);
    }
    
    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }
}