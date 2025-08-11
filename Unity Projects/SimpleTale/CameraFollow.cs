using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float edgeBuffer = 2f; // Distance from screen edge before camera moves
    public float camSpeed = 5f;  // Speed of camera movement
    
    private Transform player;
    private Camera cam;

    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        cam = GetComponent<Camera>();

    }
    
    void LateUpdate()
    {
        if (player == null) return;
        
        // Get screen bounds in world coordinates
        Vector3 playerScreenPos = cam.WorldToViewportPoint(player.position);
        
        // Calculate how much to move camera
        Vector3 cameraMove = Vector3.zero;
        
        // Check horizontal edges (0 = left, 1 = right)
        float edgeThreshold = edgeBuffer / (cam.orthographicSize * 2 * cam.aspect);
        
        if (playerScreenPos.x < edgeThreshold) // Too far left
            cameraMove.x = (playerScreenPos.x - edgeThreshold) * cam.orthographicSize * 2 * cam.aspect;
        else if (playerScreenPos.x > 1 - edgeThreshold) // Too far right
            cameraMove.x = (playerScreenPos.x - (1 - edgeThreshold)) * cam.orthographicSize * 2 * cam.aspect;
            
        // Check vertical edges (0 = bottom, 1 = top)
        float verticalThreshold = edgeBuffer / (cam.orthographicSize * 2);
        
        if (playerScreenPos.y < verticalThreshold) // Too far down
            cameraMove.y = (playerScreenPos.y - verticalThreshold) * cam.orthographicSize * 2;
        else if (playerScreenPos.y > 1 - verticalThreshold) // Too far up
            cameraMove.y = (playerScreenPos.y - (1 - verticalThreshold)) * cam.orthographicSize * 2;
            
        // Move camera smoothly
        transform.position += cameraMove * camSpeed * Time.deltaTime;
    }
}