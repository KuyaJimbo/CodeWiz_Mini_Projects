using UnityEngine;

public class TouchCheckpoint : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Transform checkpointSpawn = transform.Find("CheckpointSpawn");
            TeleportPlayer teleportScript = collision.gameObject.GetComponent<TeleportPlayer>();
            teleportScript.SetCheckpoint(checkpointSpawn);
        }
    }
}
