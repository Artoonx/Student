using System.Collections;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int gemsToOpen;
    [SerializeField] float openDelay;

    private int destroyGem;
    private bool isOpen = false;

    void OnEnable()
    {
        GameEvents.OnTargetDestroyed += HandleTargetDestroyed;
      
    }
    void OnDisable()
    {
        GameEvents.OnTargetDestroyed -= HandleTargetDestroyed;
    }

    void HandleTargetDestroyed(GameItem gameItem)
    {
        destroyGem++;

        if (destroyGem >= gemsToOpen)
        {
            isOpen = true;
            if (isOpen)
            {
                StartCoroutine(OpenAfterDelay());
            }
           
        }
    }

    private IEnumerator OpenAfterDelay()
    {
        isOpen = true;
        yield return new WaitForSeconds(openDelay);
        gameObject.SetActive(false);
        isOpen = false;
    }
}
