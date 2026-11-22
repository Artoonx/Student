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
        float distance = Vector2.Distance(current, target);

        if (distance <= maxDelta)
        {
            return target;
        }

        Vector2 direction = (target - current).normalized;
        return current + direction * maxDelta;
    }
       
    
}
