using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float smoothSpeed = 0.125f;
    [SerializeField] private Vector3 offset = new Vector3(0, 2, -10);
    [SerializeField] private float minX = -10f;
    [SerializeField] private float maxX = 10f;
    
    void LateUpdate()
    {
        if (player == null) return;
        
        // Calculate desired position
        Vector3 desiredPosition = player.position + offset;
        
        // Clamp X position (optional boundaries)
        desiredPosition.x = Mathf.Clamp(desiredPosition.x, minX, maxX);
        
        // Smooth movement
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}