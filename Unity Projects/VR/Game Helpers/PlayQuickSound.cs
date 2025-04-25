using UnityEngine;

public class PlayQuickSound : MonoBehaviour
{
    [Header("Assign your audio clip here")]
    public AudioClip clip;

    [Tooltip("Volume to play the sound at (0.0 to 1.0)")]
    public float volume = 1.0f;

    /// <summary>
    /// Plays the audio clip at the current position.
    /// </summary>
    public void PlayClipAtPoint()
    {
        if (clip != null)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position, volume);
        }
        else
        {
            Debug.LogWarning("No audio clip assigned to PlayQuickSound.");
        }
    }
}
