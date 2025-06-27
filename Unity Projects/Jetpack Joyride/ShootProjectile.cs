using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    // Create a reference to the projectile prefab
    public GameObject projectilePrefab;

    void Update()
    {
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate the projectile at the player's position and rotation
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
