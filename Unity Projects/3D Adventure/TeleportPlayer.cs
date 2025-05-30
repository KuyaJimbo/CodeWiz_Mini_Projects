using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public Transform teleportTarget; // The target position to teleport to

    // Set teleport target
    public void SetTeleportTarget(Transform target)
    {
        // Set the teleport target to the provided transform
        teleportTarget = target;
    }

    // Teleport the player to the target position
    public void TeleportPlayer()
    {
        // Teleport the player to the target position
        transform.position = teleportTarget.position;
        // Optionally, reset the player's rotation to match the target's rotation
        transform.rotation = teleportTarget.rotation;

    }
}
