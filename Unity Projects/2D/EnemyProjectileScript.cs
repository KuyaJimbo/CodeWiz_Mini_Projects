using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileScript : MonoBehaviour
{
    // speed of the projectile
    public float speed = 10.0f;
    // 2D movement vector
    private Vector2 moveVector2D;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // move the projectile to the right 2D direction
        moveVector2D = new Vector2(speed * Time.deltaTime, 0.0f);
        transform.Translate(moveVector2D);
    }
}
