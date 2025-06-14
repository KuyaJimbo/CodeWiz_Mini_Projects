using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckpointSound : MonoBehaviour
{
    public AudioClip checkpointSound; // Sound to play when the player reaches the goal

    // When the player collides with the Checkpoint, show the next level button
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(checkpointSound, transform.position); // Play the checkpoint sound
        }
    }
}
