using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [Header("Sound Settings")]
    public AudioClip soundToPlay; // The audio clip to play
    public float volume = 1f; // Volume of the sound (0.0 to 1.0)

    [Header("Sound Options")]
    public bool playAtPoint = false; // Play sound at object's position or use AudioSource
    public bool randomizePitch = false; // Randomize pitch slightly for variety
    public Vector2 pitchRange = new Vector2(0.8f, 1.2f); // Range for pitch randomization

    private AudioSource audioSource;

    private void Start()
    {
        // If not playing at point, ensure we have an AudioSource
        if (!playAtPoint)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
        }
    }

    /// <summary>
    /// Public method to play the sound
    /// </summary>
    public void Play()
    {
        // Verify sound clip exists
        if (soundToPlay == null)
        {
            Debug.LogWarning("No sound clip assigned to PlaySound script!");
            return;
        }

        // Play sound at point or using AudioSource
        if (playAtPoint)
        {
            // Optionally randomize pitch
            float pitch = randomizePitch
                ? Random.Range(pitchRange.x, pitchRange.y)
                : 1f;

            AudioSource.PlayClipAtPoint(soundToPlay, transform.position, volume);
        }
        else
        {
            // Optionally randomize pitch
            if (randomizePitch)
            {
                audioSource.pitch = Random.Range(pitchRange.x, pitchRange.y);
            }
            else
            {
                audioSource.pitch = 1f;
            }

            // Play the sound
            audioSource.PlayOneShot(soundToPlay, volume);
        }
    }
}