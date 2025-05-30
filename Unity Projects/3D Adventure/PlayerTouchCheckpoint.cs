using UnityEngine;

public class PlayerTouchCheckpoint : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Transform checkpointSpawn = transform.Find("CheckpointSpawn");

            if (checkpointSpawn != null)
            {
                TeleportPlayer teleportScript = collision.gameObject.GetComponent<TeleportPlayer>();

                if (teleportScript != null)
                {
                    teleportScript.SetCheckpoint(checkpointSpawn);
                }
                else
                {
                    Debug.LogWarning("TeleportPlayer script not found on Player.");
                }
            }
            else
            {
                Debug.LogWarning("CheckpointSpawn child not found on checkpoint object.");
            }
        }
    }
}
