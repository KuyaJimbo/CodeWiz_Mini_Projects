using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Create the VARIABLES:
    // Jump Force (Hint: float)


    // Rigidbody component (Hint: Rigidbody)


    // Ground check (Hint: bool)


    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component attached to this GameObject
        // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player is grounded AND the space key is pressed (Hint: Grounded && Input.GetKeyDown(KeyCode.Space))
        // AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Apply a force to the Rigidbody to make it jump
        // Set your ground check to false (Hint: Grounded = false)




    }

    // collides with the ground layer mask
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object has layer mask "Ground"
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            // Set your ground check to true (Hint: Grounded = true)

        }
    }
}
