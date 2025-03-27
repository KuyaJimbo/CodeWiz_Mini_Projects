using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // reference to the player object
    public GameObject player;
    // reference to the enemy projectile object
    public GameObject enemyProjectile;
    // fire rate
    public float fireRate = 1.5f;
    // timer
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireRate && GetDistanceToPlayer() < 10.0f)
        {
            // reset timer
            timer = 0.0f;
            // spawn it upside down if player is on the left side
            if (player.transform.position.x < transform.position.x)
            {
                Instantiate(enemyProjectile, transform.position, Quaternion.Euler(0.0f, 0.0f, 180.0f));
            }
            else
            {
                Instantiate(enemyProjectile, transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
            }

        }
    }

    // get distance to player object
    public float GetDistanceToPlayer()
    {
        return Vector3.Distance(player.transform.position, transform.position);
    }
}
