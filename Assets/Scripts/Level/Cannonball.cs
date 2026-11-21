using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Cannonball : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody2D;
    [SerializeField] float maxDistance;

    Vector2 startPosition;

    void Awake()
    {
        startPosition = transform.position;
    }

    public void Launch(Vector2 velocity)
    {
        rigidBody2D.linearVelocity = velocity;
    }

    void Update()
    {
        Vector2 position = transform.position;
        Vector2 travelled = position - startPosition;

        if (travelled.magnitude > maxDistance)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
