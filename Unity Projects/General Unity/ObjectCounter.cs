using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ObjectCounter : MonoBehaviour
{
    public string objectTag; // The tag to search for
    public TextMeshProUGUI countText; // UI text to display the count
    public GameObject button; // The UI button to activate

    void Start()
    {
        // Check if objectTag is set
        if (string.IsNullOrEmpty(objectTag))
        {
            Debug.LogWarning("ObjectCounter: No tag specified! Please assign a tag in the Inspector.");
        }

        // Check if countText is assigned
        if (countText == null)
        {
            Debug.LogError("ObjectCounter: No TextMeshPro UI assigned! Please assign a UI TextMeshPro element.");
        }

        // Check if button is assigned
        if (button == null)
        {
            Debug.LogError("ObjectCounter: No Button GameObject assigned! Please assign a UI Button element.");
        }
        
        UpdateCount();
    }

    void Update()
    {
        UpdateCount();
    }

    void UpdateCount()
    {
        if (string.IsNullOrEmpty(objectTag))
            return; // Skip execution if no tag is provided

        int count = GameObject.FindGameObjectsWithTag(objectTag).Length; // Count objects with tag

        // Check if countText is assigned before updating it
        if (countText != null)
        {
            countText.text = "Objects Remaining: " + count; // Update UI text
        }

        // Check if button is assigned before activating it
        if (button != null)
        {
            button.SetActive(count == 0);
        }
    }
}
