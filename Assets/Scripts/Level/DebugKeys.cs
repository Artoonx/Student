using UnityEngine;
using UnityEngine.InputSystem;

// Debug shortcut for testing: R makes the player reappear at the respawn point.
public class DebugKeys : MonoBehaviour
{
    [SerializeField] PlayerPhysics player;
    [SerializeField] Transform respawnPoint;

    void Update()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            RespawnPlayer();
        }
    }

    void RespawnPlayer()
    {
        player.gameObject.SetActive(false);
        player.transform.position = respawnPoint.position;
        player.gameObject.SetActive(true);
    }
}
