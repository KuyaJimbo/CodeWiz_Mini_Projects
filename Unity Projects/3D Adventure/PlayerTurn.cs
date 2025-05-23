using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    // This script is used to turn the object smoothly when the left or right arrow key is pressed.
    public float turnSpeed = 50.0f; // The speed at which the object turns

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if press left arrow key, turn left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -1 * turnSpeed * Time.deltaTime);
        }

        // if press right arrow key, turn right (Hint: KeyCode.RightArrow)
        // if (Input.GetKey(KeyCode.____________))
        // {
        //     transform.Rotate(____________, 1 * ____________ * Time.deltaTime);
        // }
    }
}
