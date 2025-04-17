using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedSound : MonoBehaviour
{
    // Reference to Sound
    public AudioClip ClickedSoundEffect;

    // Use OnMouseDown to play sound when clicked
    private void OnMouseDown()
    {
        // Play the sound effect
        AudioSource.PlayClipAtPoint(ClickedSoundEffect, transform.position);
    }
}