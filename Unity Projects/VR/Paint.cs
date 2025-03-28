using UnityEngine;

public class Paint : MonoBehaviour
{
    [Header("Paint Settings")]
    public Color paintColor; // Color of the projectile

    [Header("Sound Settings")]
    public AudioClip collisionSound; // Sound to play on collision
    public float soundVolume = 0.5f; // Volume of the collision sound

    private AudioSource audioSource;

    private void Start()
    {
        // If no color is set, randomize the paint color
        if (paintColor == Color.clear || paintColor == Color.white)
        {
            paintColor = Random.ColorHSV(0f, 1f, 0.5f, 1f, 0.5f, 1f);
        }

        // Ensure an AudioSource component exists
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Try to get the renderer of the collided object
        Renderer objectRenderer = collision.gameObject.GetComponent<Renderer>();

        // If the object has a renderer, change its color
        if (objectRenderer != null)
        {
            // Check if the renderer has a material
            if (objectRenderer.material != null)
            {
                objectRenderer.material.color = paintColor;
            }
        }

        // Play collision sound if available
        if (collisionSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(collisionSound, soundVolume);
        }
    }
}