using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    private Transform lastCheckpoint;

    public void SetCheckpoint(Transform newCheckpoint)
    {
        lastCheckpoint = newCheckpoint;
        Debug.Log("Checkpoint updated to: " + newCheckpoint.position);
    }

    public void TeleportToCheckpoint()
    {
        if (lastCheckpoint != null)
        {
            transform.position = lastCheckpoint.position;
            Debug.Log("Teleported to last checkpoint.");
        }
        else
        {
            Debug.LogWarning("No checkpoint has been set.");
        }
    }
}
