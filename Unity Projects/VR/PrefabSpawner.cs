using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject prefabToSpawn;
    public float spawnDistance = 2f;
    
    void Update()
    {
        // Check if space key was pressed this frame
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPrefab();
        }
    }
    
    void SpawnPrefab()
    {
        // Check if we have a prefab assigned
        if (prefabToSpawn == null)
        {
            Debug.LogWarning("No prefab assigned to spawn!");
            return;
        }
        
        // Calculate spawn position in front of this object
        Vector3 spawnPosition = transform.position + transform.forward * spawnDistance;
        
        // Spawn the prefab with the same rotation as this object
        Instantiate(prefabToSpawn, spawnPosition, transform.rotation);
    }
}
