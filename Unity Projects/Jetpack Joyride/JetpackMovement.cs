using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetpackMovement : MonoBehaviour
{
    public int speed = 5;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

        }
    }
}
