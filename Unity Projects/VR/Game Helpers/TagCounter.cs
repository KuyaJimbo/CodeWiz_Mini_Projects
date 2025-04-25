using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TagCounter : MonoBehaviour
{
    [Tooltip("List of tags to count")]
    public List<string> tagsToCount = new List<string>();
    
    [Tooltip("Current count of objects with specified tags")]
    public int count;
    
    [Tooltip("TextMeshPro component to display the count")]
    public TextMeshProUGUI countText;
    
    private void Update()
    {
        // Reset count
        count = 0;
        
        // Count objects for each tag in the list
        foreach (string tag in tagsToCount)
        {
            if (string.IsNullOrEmpty(tag))
                continue;
                
            // Find all game objects with the current tag and add to count
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);
            count += taggedObjects.Length;
        }
        
        // Update the TextMeshPro text
        if (countText != null)
        {
            countText.text = "Total Remaining: " + count;
        }
    }
}