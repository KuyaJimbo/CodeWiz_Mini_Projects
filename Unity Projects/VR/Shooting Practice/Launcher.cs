using UnityEngine;


public class Launcher : MonoBehaviour
{
    [Header("Projectile Settings")]
    public GameObject projectilePrefab; // Prefab of the projectile to spawn
    public Transform exitPoint; // Reference to the Exit Point transform
    
    [Header("Shooting Parameters")]
    public float shootForce = 20f; // Force applied to the projectile
    public float projectileLifetime = 5f; // How long the projectile exists before being destroyed

    /// <summary>
    /// Shoots a projectile from the launcher's exit point
    /// </summary>
    public void Shoot()
    {
        // Check if projectile prefab and exit point are set
        if (projectilePrefab == null || exitPoint == null)
        {
            Debug.LogWarning("Projectile prefab or exit point is not set!");
            return;
        }

        // Instantiate the projectile at the exit point's position and rotation
        GameObject firedProjectile = Instantiate(
            projectilePrefab, 
            exitPoint.position, 
            exitPoint.rotation
        );

        // Get the Rigidbody component of the projectile
        Rigidbody projectileRb = firedProjectile.GetComponent<Rigidbody>();

        // Apply forward force if Rigidbody exists
        if (projectileRb != null)
        {
            projectileRb.AddForce(exitPoint.forward * shootForce, ForceMode.Impulse);
        }
        else
        {
            Debug.LogWarning("Projectile is missing a Rigidbody component!");
        }

        // Destroy the projectile after its lifetime
        Destroy(firedProjectile, projectileLifetime);
    }

    // Optional: You can use this method to configure the XR Grab Interactable's activation
    private void ConfigureXRGrabInteractable()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        if (grabInteractable != null)
        {
            // Assuming you want to call Shoot when the object is activated
            grabInteractable.activated.AddListener(_ => Shoot());
        }
    }

    // Use Awake to set up the XR Grab Interactable listener
    private void Awake()
    {
        ConfigureXRGrabInteractable();
    }
}