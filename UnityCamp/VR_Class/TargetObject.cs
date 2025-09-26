using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TargetObject : MonoBehaviour
{
    public AudioClip destroySound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            // Play the destroy sound at the target's position
            if (destroySound)
            {
                AudioSource.PlayClipAtPoint(destroySound, transform.position);
            }

            // Destroy the target object
            Destroy(gameObject);
        }
    }
}
