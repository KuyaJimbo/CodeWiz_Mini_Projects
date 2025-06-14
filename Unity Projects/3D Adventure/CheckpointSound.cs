using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckpointSound : MonoBehaviour
{
    public AudioClip checkpointSound; // Sound to play when the player reaches the goal

    // When the game starts, hide the next level button
    void Start()
    {
        nextLevelButton.SetActive(false); // Hide the next level button at the start
    }

    // When the player collides with the Checkpoint, show the next level button
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nextLevelButton.SetActive(true); // Show the next level button when the player reaches a checkpoint
            AudioSource.PlayClipAtPoint(checkpointSound, transform.position); // Play the checkpoint sound
        }
    }

    // Method to load the next level when the button is clicked
    public void LoadNextLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
