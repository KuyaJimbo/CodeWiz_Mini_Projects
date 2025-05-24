using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Create the VARIABLES:
    // PUBLIC Movement Speed Variable(Hint: float)
    public float movementSpeed = 500f;
    // PRIVATE Rigidbody component (Hint: Rigidbody)


    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component attached to this GameObject
        // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // (KeyCode Hints: KeyCode.W, KeyCode.S, KeyCode.A, KeyCode.D)
        // (AddForce Hints: transform.forward, transform.right, -transform.forward, -transform.right)

        // Move the object forward examples
        if (Input.GetKey(KeyCode.W))
        {
            // Push the object forward with a force on the Rigidbody
            rb.AddForce(transform.forward * movementSpeed * Time.deltaTime);
        }

        // // Move the player backward
        // if (Input.GetKey(_____________))
        // {
        //     // Push the object backward with a force on the Rigidbody
        //     rb.AddForce(_____________ * movementSpeed * Time.deltaTime);
        // }

        // // Move the player left
        // if (Input.GetKey(_____________))
        // {
        //     // Push the object left with a force on the Rigidbody
        //     rb.AddForce(_____________ * movementSpeed * Time.deltaTime);
        // }

        // // Move the player right
        // if (Input.GetKey(_____________))
        // {
        //     // Push the object right with a force on the Rigidbody
        //     rb.AddForce(_____________ * movementSpeed * Time.deltaTime);
        // }
        
    }
}
