using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLeft : MonoBehaviour
{
    void Update()
    {
        // Move the object to the left at a constant speed
        transform.Translate(Vector3.left * Time.deltaTime * 5f);

        // If the object goes off-screen, destroy it
        if (transform.position.x < -10f)
        {

        }
    }
}
