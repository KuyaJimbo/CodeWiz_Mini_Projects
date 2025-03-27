# Unity 2D Game - Animations and Boosts Implementation Guide

This README provides step-by-step instructions for implementing animations and power-up boosts in your 2D Unity game using the PlayerController script.

## Table of Contents
- [Setting Up Animations](#setting-up-animations)
- [Implementing Power-up Boosts](#implementing-power-up-boosts)
- [Additional Features](#additional-features)

## Setting Up Animations

### 1. Required Components
Ensure your player GameObject has the following components:
- Rigidbody2D
- BoxCollider2D
- SpriteRenderer
- Animator

### 2. Creating the Animator Controller
1. In the Project window, right-click and select **Create > Animator Controller**
2. Name it "PlayerAnimator"
3. Drag and drop it onto your player GameObject

### 3. Setting Up Animation Parameters
1. Open the Animator window (Window > Animation > Animator)
2. Add the following parameters:
   - **A_Run** (Float) - Controls running animation based on movement speed
   - **A_Jump** (Trigger) - Activates jumping animation
   - **A_Attack** (Trigger) - Activates attack animation

### 4. Creating Animation Clips
1. Select your player GameObject
2. Open the Animation window (Window > Animation > Animation)
3. Create the following animation clips:
   - **Idle** - Player's idle stance
   - **Run** - Running animation
   - **Jump** - Jumping animation
   - **Attack** - Attack animation

### 5. Setting Up Animator Transitions
1. In the Animator window, create transitions between states:
   - **Idle → Run**: When A_Run > 0.1
   - **Run → Idle**: When A_Run < 0.1
   - **Any State → Jump**: When A_Jump is triggered
   - **Any State → Attack**: When A_Attack is triggered
2. For Jump and Attack, check "Has Exit Time" to return to previous state after animation completes

### 6. Script Integration
The PlayerController script already handles animation triggering:
- `animator.SetFloat("A_Run", Mathf.Abs(moveInput))` - Updates the Run parameter
- `animator.SetTrigger("A_Jump")` - Triggers Jump animation
- `animator.SetTrigger("A_Attack")` - Triggers Attack animation

## Implementing Power-up Boosts

### 1. Understanding Coroutines and IEnumerator
The PlayerController script uses IEnumerator functions and coroutines to implement temporary stat boosts:
- Coroutines allow execution to pause and resume over time
- The `yield return` statement pauses execution for a specified duration
- Coroutines must be started with `StartCoroutine()`

### 2. Speed Boost Implementation
The script already includes a speed boost implementation:
```csharp
public IEnumerator ApplyMoveSpeedBoost(float duration, float boost)
{
    // Apply the boost
    moveSpeed = originalMoveSpeed * boost;
    
    // Wait for the duration
    yield return new WaitForSeconds(duration);
    
    // Restore the original value
    moveSpeed = originalMoveSpeed;
}
```

### 3. Adding a Jump Boost
1. Add a variable to store the original jump force:
```csharp
private float originalJumpForce;
```

2. Initialize it in Start():
```csharp
void Start()
{
    // Existing code...
    originalJumpForce = jumpForce;
}
```

3. Create the jump boost method:
```csharp
public IEnumerator ApplyJumpBoost(float duration, float boost)
{
    // Store original value
    float originalValue = jumpForce;
    
    // Apply boost
    jumpForce = originalValue * boost;
    
    // Wait for duration
    yield return new WaitForSeconds(duration);
    
    // Restore original value
    jumpForce = originalValue;
}
```

### 4. Update the Generic Boost Method
Modify the `ApplyBoost` method to handle jump force:
```csharp
public IEnumerator ApplyBoost(float duration, float boost, string statName)
{
    if (statName == "moveSpeed")
    {
        float original = moveSpeed;
        moveSpeed *= boost;
        
        yield return new WaitForSeconds(duration);
        
        moveSpeed = original;
    }
    else if (statName == "jumpForce")
    {
        float original = jumpForce;
        jumpForce *= boost;
        
        yield return new WaitForSeconds(duration);
        
        jumpForce = original;
    }
    // Add more stats as needed
}
```

### 5. Add Jump Boost Power-up Pickup
Modify the `OnTriggerEnter2D` method to handle jump boost power-ups:
```csharp
void OnTriggerEnter2D(Collider2D other)
{
    // Existing code...
    
    else if (other.CompareTag("JumpBoost"))
    {
        StartCoroutine(ApplyJumpBoost(5f, 1.5f));
        Destroy(other.gameObject);
    }
}
```

## Additional Features

### 1. Creating Power-up GameObjects
1. Create new GameObjects for each power-up type
2. Add SpriteRenderer and Collider2D components
   - Make sure to check "Is Trigger" on the collider
3. Add appropriate tags: "SpeedBoost" and "JumpBoost"

### 2. Visual Feedback for Active Boosts
Consider adding visual feedback when boosts are active:
```csharp
public IEnumerator ApplyMoveSpeedBoost(float duration, float boost)
{
    // Apply the boost
    moveSpeed = originalMoveSpeed * boost;
    
    // Visual feedback - change color
    Color originalColor = spriteRenderer.color;
    spriteRenderer.color = Color.yellow; // Speed boost color
    
    // Wait for the duration
    yield return new WaitForSeconds(duration);
    
    // Restore the original values
    moveSpeed = originalMoveSpeed;
    spriteRenderer.color = originalColor;
}
```

### 3. Testing Boosts
- Use the 'B' key to test speed boost manually (already implemented)
- Add a similar test key for jump boost:
```csharp
if (Input.GetKeyDown(KeyCode.J))
{
    StartCoroutine(ApplyJumpBoost(5f, 1.5f));
}
```

### 4. Adding Sound Effects
Consider adding sound effects when boosts are activated:
```csharp
public AudioClip speedBoostSound;
public AudioClip jumpBoostSound;
private AudioSource audioSource;

void Start()
{
    // Existing code...
    audioSource = GetComponent<AudioSource>();
}

public IEnumerator ApplyMoveSpeedBoost(float duration, float boost)
{
    // Play sound effect
    if (audioSource && speedBoostSound)
        audioSource.PlayOneShot(speedBoostSound);
        
    // Rest of the method...
}
```

Happy game development!
