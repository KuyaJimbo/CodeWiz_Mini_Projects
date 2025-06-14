using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    public GameObject nextLevelButton; // Reference to the next level button
    public AudioClip goalReachedSound; // Sound to play when the player reaches the goal

    // When the game starts, hide the next level button
    void Start()
    {
        nextLevelButton.SetActive(false); // Hide the next level button at the start
    }

    // When the player collides with the goal, show the next level button
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nextLevelButton.SetActive(true); // Show the next level button when the player reaches the goal
            AudioSource.PlayClipAtPoint(goalReachedSound, transform.position); // Play the goal reached sound
        }
    }

    // Method to load the next level when the button is clicked
    public void LoadNextLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
