using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform muzzle;
    [SerializeField] Cannonball cannonballPrefab;
    [SerializeField] float ballSpeed;
    [SerializeField] float fireDelay;

    float fireTimer;

    void Start()
    {
        fireTimer = fireDelay;
    }

    void Update()
    {
        fireTimer -= Time.deltaTime;

        if (fireTimer <= 0.0f)
        {
            Fire();
            fireTimer = fireDelay;
        }
    }

    void Fire()
    {
        if (player == null)
        {
            return;
        }

        Vector2 direction = (player.position - muzzle.position).normalized;

        var cannonball = Instantiate(cannonballPrefab,
            muzzle.position,
            Quaternion.identity);
        cannonball.Launch(direction * ballSpeed);
    }
}
