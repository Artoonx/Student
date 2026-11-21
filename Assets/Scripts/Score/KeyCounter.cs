using UnityEngine;

public class KeyCounter : MonoBehaviour
{
    int keysDestroyed;

    void Start()
    {
        
    }

    void OnEnable()
    {
        GameEvents.OnTargetDestroyed += TargetDestroyedHandler;
    }

    void OnDisable()
    {
        GameEvents.OnTargetDestroyed -= TargetDestroyedHandler;
    }

    void TargetDestroyedHandler(GameItem gameItem)
    {
        if (gameItem == GameItem.Key)
        {
            keysDestroyed++;
            Debug.Log($"Llaves destruidas: {keysDestroyed}");
        }
    }
}
