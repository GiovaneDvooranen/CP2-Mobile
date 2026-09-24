using UnityEngine;
using DG.Tweening;

public class EnemyHealth : MonoBehaviour
{
    private Vector3 originalScale;
    public int hp = 50;

    public int scoreValue = 10;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        PlayHitEffect();

        if (hp <= 0)
        {
            ScoreManager.Instance.AddScore(scoreValue);

            Destroy(gameObject);
        }
    }

    private void PlayHitEffect()
    {
        transform.DOKill();

        transform.DOPunchScale(
        Vector3.one * 0.4f,
        0.2f,
        5,
        0.5f
        );
    }

}