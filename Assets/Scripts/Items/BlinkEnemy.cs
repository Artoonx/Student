using System.Collections;
using UnityEngine;

public class BlinkEnemy : MonoBehaviour, IDamagable
{
    [SerializeField] Collider2D enemyCollider;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Color hitColor;
    [SerializeField] float blinkWait;
    [SerializeField] int blinkTimes;

    public void Damage(int direction)
    {
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        enemyCollider.enabled = false;
        spriteRenderer.color = hitColor;

        for (int i = 0; i < blinkTimes; i++)
        {
            gameObject.SetActive(false);
            yield return new WaitForSeconds(blinkWait);
            gameObject.SetActive(true);
            yield return new WaitForSeconds(blinkWait);
        }

        spriteRenderer.color = Color.white;
        enemyCollider.enabled = true;
    }
}
