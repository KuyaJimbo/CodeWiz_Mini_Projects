using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    public GameObject nextButton; // Reference to the next level button
    public AudioClip goalSound; // Sound to play when the player reaches the goal

    // When the game starts, hide the next level button
    void Start()
    {
        nextButton.SetActive(false); // Hide the next level button at the start
    }

    // When the player collides with the goal, show the next level button
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nextButton.SetActive(true); // Show the next level button when the player reaches the goal
            AudioSource.PlayClipAtPoint(goalSound, transform.position); // Play the goal reached sound
        }
    }

    // Method to load the next level when the button is clicked
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
