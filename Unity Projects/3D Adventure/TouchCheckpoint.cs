using UnityEngine;

public class TouchCheckpoint : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Transform checkpointSpawn = transform.Find("CheckpointSpawn");
            PlayerTeleport teleportScript = collision.gameObject.GetComponent<PlayerTeleport>();
            teleportScript.SetTeleportTarget(checkpointSpawn);
        }
    }
}
