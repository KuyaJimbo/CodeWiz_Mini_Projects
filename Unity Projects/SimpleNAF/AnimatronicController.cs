using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class LocationCameraPair
{
    [Header("Drag parent object (with Camera + Position as children)")]
    public Transform locationRoot;

    [Header("Optional UI")]
    public Button cameraButton;

    // Auto-filled
    [HideInInspector] public Transform locationTransform;
    [HideInInspector] public Camera associatedCamera;
    [HideInInspector] public string locationName;
}

public class AnimatronicController : MonoBehaviour
{
    [Header("Animatronic Settings")]
    public Transform animatronicTransform;
    public float moveSpeed = 2f;
    public float rotationSpeed = 90f; // Degrees per second
    public int currentLocationIndex = 0;

    [Header("Movement Behavior")]
    public float movementInterval = 10f;
    public float retreatChance = 0.7f;
    public bool faceMovementDirection = true;
    public bool smoothMovement = true;

    [Header("Location-Camera Pairs")]
    public List<LocationCameraPair> locations = new List<LocationCameraPair>();

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip movementSound;
    public AudioClip retreatSound;
    public AudioClip rotationSound;

    [Header("Debug")]
    public bool enableDebugLogs = true;

    private Camera currentlyActiveCamera;
    private bool isMoving = false;
    private bool isRotating = false;
    private bool playerWatchingCurrentLocation = false;
    private Coroutine movementCoroutine;

    // Events
    public System.Action<int> OnAnimatronicMoved;
    public System.Action<int> OnAnimatronicRetreated;
    public System.Action OnAnimatronicStartedMoving;
    public System.Action OnAnimatronicStoppedMoving;

    void Start()
    {
        InitializeSystem();
        StartMovementCoroutine();
    }

    void InitializeSystem()
    {
        if (locations.Count == 0)
        {
            Debug.LogError("No locations set up for animatronic!");
            return;
        }

        foreach (var loc in locations)
        {
            if (loc.locationRoot == null)
            {
                Debug.LogError("Location root is missing on one of the pairs!");
                continue;
            }

            loc.associatedCamera = loc.locationRoot.GetComponentInChildren<Camera>(true);

            // Find a child explicitly marked "Position"
            foreach (Transform child in loc.locationRoot)
            {
                if (child.name.ToLower().Contains("position"))
                {
                    loc.locationTransform = child;
                    break;
                }
            }

            loc.locationName = loc.locationRoot.name;

            if (loc.associatedCamera != null)
                loc.associatedCamera.gameObject.SetActive(false);

            if (loc.cameraButton != null)
            {
                LocationCameraPair capturedLoc = loc;
                loc.cameraButton.onClick.AddListener(() =>
                {
                    if (enableDebugLogs)
                        Debug.Log($"[Button Click] Camera button pressed for {capturedLoc.locationName}");
                    ToggleCamera(locations.IndexOf(capturedLoc));
                });
            }
        }

        if (animatronicTransform != null && locations[currentLocationIndex].locationTransform != null)
        {
            animatronicTransform.position = locations[currentLocationIndex].locationTransform.position;
        }

        if (enableDebugLogs)
            Debug.Log($"Animatronic initialized at location: {locations[currentLocationIndex].locationName}");
    }

    public void ToggleCamera(int locationIndex)
    {
        if (locationIndex < 0 || locationIndex >= locations.Count)
        {
            Debug.LogWarning($"Invalid camera index: {locationIndex}");
            return;
        }

        LocationCameraPair targetLocation = locations[locationIndex];

        if (currentlyActiveCamera == targetLocation.associatedCamera)
        {
            DeactivateAllCameras();
            if (enableDebugLogs)
                Debug.Log($"Deactivated camera: {targetLocation.locationName}");
            return;
        }

        DeactivateAllCameras();

        if (targetLocation.associatedCamera != null)
        {
            targetLocation.associatedCamera.gameObject.SetActive(true);
            currentlyActiveCamera = targetLocation.associatedCamera;

            CheckIfPlayerWatchingAnimatronic();

            if (enableDebugLogs)
                Debug.Log($"Activated camera: {targetLocation.locationName}");
        }
    }

    void DeactivateAllCameras()
    {
        foreach (var loc in locations)
        {
            if (loc.associatedCamera != null)
                loc.associatedCamera.gameObject.SetActive(false);
        }
        currentlyActiveCamera = null;
        playerWatchingCurrentLocation = false;
    }

    void CheckIfPlayerWatchingAnimatronic()
    {
        if (currentlyActiveCamera != null)
        {
            playerWatchingCurrentLocation = (currentlyActiveCamera == locations[currentLocationIndex].associatedCamera);
            if (playerWatchingCurrentLocation && enableDebugLogs)
                Debug.Log("Player is watching the animatronic's location!");
        }
    }

    void StartMovementCoroutine()
    {
        if (movementCoroutine != null)
            StopCoroutine(movementCoroutine);

        movementCoroutine = StartCoroutine(MovementLoop());
    }

    IEnumerator MovementLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(movementInterval);

            if (!isMoving && !isRotating)
                yield return StartCoroutine(AttemptMovement());
        }
    }

    IEnumerator AttemptMovement()
    {
        isMoving = true;
        OnAnimatronicStartedMoving?.Invoke();

        int targetLocationIndex = GetRandomAdjacentLocation();

        if (enableDebugLogs)
        {
            string current = locations[currentLocationIndex].locationName;
            string target = targetLocationIndex >= 0 ? locations[targetLocationIndex].locationName : "None";
            Debug.Log($"[Movement Attempt] Current: {current}, Target: {target}");
        }

        if (targetLocationIndex == -1)
        {
            isMoving = false;
            OnAnimatronicStoppedMoving?.Invoke();
            yield break;
        }

        LocationCameraPair targetLocation = locations[targetLocationIndex];

        bool playerWatchingTarget = (currentlyActiveCamera == targetLocation.associatedCamera);
        bool shouldRetreat = playerWatchingCurrentLocation || playerWatchingTarget;

        if (enableDebugLogs)
            Debug.Log($"Decision: Retreat={shouldRetreat}, PlayerWatchingTarget={playerWatchingTarget}");

        if (shouldRetreat && Random.value < retreatChance)
        {
            yield return StartCoroutine(RetreatToSafeLocation());
        }
        else if (!playerWatchingTarget)
        {
            yield return StartCoroutine(MoveToLocation(targetLocationIndex));
        }
        else
        {
            if (enableDebugLogs)
                Debug.Log($"Blocked: Player watching {targetLocation.locationName}");
        }

        isMoving = false;
        OnAnimatronicStoppedMoving?.Invoke();
    }

    int GetRandomAdjacentLocation()
    {
        List<int> validLocations = new List<int>();
        for (int i = 0; i < locations.Count; i++)
        {
            if (i != currentLocationIndex)
                validLocations.Add(i);
        }

        if (validLocations.Count == 0)
            return -1;

        return validLocations[Random.Range(0, validLocations.Count)];
    }

    IEnumerator RotateTowards(Vector3 targetDirection)
    {
        if (animatronicTransform == null || !faceMovementDirection)
            yield break;

        isRotating = true;

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection.normalized);
        Quaternion startRotation = animatronicTransform.rotation;

        if (audioSource != null && rotationSound != null)
            audioSource.PlayOneShot(rotationSound);

        float rotationTime = Quaternion.Angle(startRotation, targetRotation) / rotationSpeed;
        float elapsedTime = 0;

        while (elapsedTime < rotationTime)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / rotationTime;
            animatronicTransform.rotation = Quaternion.Slerp(startRotation, targetRotation, t);
            yield return null;
        }

        animatronicTransform.rotation = targetRotation;
        isRotating = false;

        if (enableDebugLogs)
            Debug.Log("Animatronic finished rotating towards target");
    }

    IEnumerator MoveToLocation(int targetIndex)
    {
        Transform targetTransform = locations[targetIndex].locationTransform;

        if (animatronicTransform == null || targetTransform == null)
            yield break;

        Vector3 startPos = animatronicTransform.position;
        Vector3 targetPos = targetTransform.position;
        Vector3 direction = (targetPos - startPos);

        if (faceMovementDirection && direction.magnitude > 0.1f)
            yield return StartCoroutine(RotateTowards(direction));

        if (audioSource != null && movementSound != null)
            audioSource.PlayOneShot(movementSound);

        float moveTime = Vector3.Distance(startPos, targetPos) / moveSpeed;
        float elapsedTime = 0;

        if (enableDebugLogs)
            Debug.Log($"[Move] {locations[currentLocationIndex].locationName} → {locations[targetIndex].locationName}, Distance={Vector3.Distance(startPos, targetPos):F2}m, Time={moveTime:F2}s");

        while (elapsedTime < moveTime)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / moveTime;

            Vector3 currentPos = smoothMovement
                ? Vector3.Lerp(startPos, targetPos, Mathf.SmoothStep(0f, 1f, t))
                : Vector3.Lerp(startPos, targetPos, t);

            animatronicTransform.position = currentPos;
            yield return null;
        }

        animatronicTransform.position = targetPos;

        int previousLocation = currentLocationIndex;
        currentLocationIndex = targetIndex;

        CheckIfPlayerWatchingAnimatronic();

        OnAnimatronicMoved?.Invoke(currentLocationIndex);

        if (enableDebugLogs)
            Debug.Log($"Animatronic moved from {locations[previousLocation].locationName} → {locations[currentLocationIndex].locationName}");
    }

    IEnumerator RetreatToSafeLocation()
    {
        List<int> safeLocations = new List<int>();

        for (int i = 0; i < locations.Count; i++)
        {
            if (currentlyActiveCamera != locations[i].associatedCamera)
                safeLocations.Add(i);
        }

        if (safeLocations.Count > 0)
        {
            int safeLocationIndex = safeLocations[Random.Range(0, safeLocations.Count)];

            if (audioSource != null && retreatSound != null)
                audioSource.PlayOneShot(retreatSound);

            yield return StartCoroutine(MoveToLocation(safeLocationIndex));

            OnAnimatronicRetreated?.Invoke(currentLocationIndex);

            if (enableDebugLogs)
                Debug.Log($"[Retreat] Animatronic retreated to {locations[currentLocationIndex].locationName}");
        }
        else
        {
            if (enableDebugLogs)
                Debug.Log("No safe retreat location available");
        }
    }

    // External controls
    public void SetMovementInterval(float newInterval) => movementInterval = newInterval;
    public void SetMoveSpeed(float newSpeed) => moveSpeed = Mathf.Max(0.1f, newSpeed);
    public void SetRotationSpeed(float newSpeed) => rotationSpeed = Mathf.Max(1f, newSpeed);
    public void PauseMovement()
    {
        if (movementCoroutine != null)
        {
            StopCoroutine(movementCoroutine);
            movementCoroutine = null;
        }
    }
    public void ResumeMovement()
    {
        if (movementCoroutine == null)
            StartMovementCoroutine();
    }
    public string GetCurrentLocationName() => (currentLocationIndex >= 0 && currentLocationIndex < locations.Count)
        ? locations[currentLocationIndex].locationName : "Unknown";
    public bool IsPlayerWatchingAnimatronic() => playerWatchingCurrentLocation;
    public bool IsAnimatronicMoving() => isMoving || isRotating;
    public Vector3 GetCurrentPosition() => animatronicTransform != null ? animatronicTransform.position : Vector3.zero;
    public float GetDistanceToLocation(int locationIndex)
    {
        if (locationIndex < 0 || locationIndex >= locations.Count || animatronicTransform == null)
            return -1f;
        return Vector3.Distance(animatronicTransform.position, locations[locationIndex].locationTransform.position);
    }

    void OnDestroy()
    {
        foreach (var loc in locations)
        {
            if (loc.cameraButton != null)
                loc.cameraButton.onClick.RemoveAllListeners();
        }
    }
}
