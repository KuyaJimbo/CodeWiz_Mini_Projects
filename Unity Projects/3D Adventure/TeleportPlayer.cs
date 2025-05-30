using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    private Transform lastCheckpoint;

    public void SetCheckpoint(Transform newCheckpoint)
    {
        lastCheckpoint = newCheckpoint;
    }

    public void TeleportToCheckpoint()
    {
        if (lastCheckpoint != null)
        {
            transform.position = lastCheckpoint.position;
        }
    }
}
