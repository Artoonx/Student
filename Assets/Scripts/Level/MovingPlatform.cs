using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;

    void Update()
    {
        Vector2 position = transform.position;
        position = MyMoveTowards(position, target.position, speed * Time.deltaTime);
        transform.position = position;
    }

    Vector2 MyMoveTowards(Vector2 current, Vector2 target, float maxDelta)
    {
        
        return current;
    }
}
