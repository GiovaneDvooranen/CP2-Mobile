using DG.Tweening;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameOverUI gameOverUI;
    public DamageFlash damageFlash;

    ShieldHandler shield;
    ArmorHandler armor;
    HealthHandler health;

    private bool dead = false;

    private Vector3 originalScale;

    void Start()
    {
        shield = new ShieldHandler();
        armor = new ArmorHandler();
        health = new HealthHandler();

        shield.SetNext(armor);
        armor.SetNext(health);

        originalScale = transform.localScale;
    }

    public void TakeDamage(float damage)
    {
        if (dead)
            return;

        shield.HandleDamage(ref damage);

        damageFlash.Flash();

        PlayHitFeedback();

        if (health.health <= 0)
        {
            dead = true;

            Debug.Log("PLAYER MORREU");

            gameOverUI.ShowGameOver(
                ScoreManager.Instance.GetScore(),
                GameManager.Instance.GetSurvivalTime()
            );
        }
    }

    private void PlayHitFeedback()
    {
        transform.DOKill();

        transform.localScale = originalScale;

        Sequence seq = DOTween.Sequence();

        seq.Append(
            transform.DOScale(
                new Vector3(
                    originalScale.x * 1.15f,
                    originalScale.y * 0.85f,
                    originalScale.z * 1.15f
                ),
                0.05f
            )
        );

        seq.Append(
            transform.DOScale(
                originalScale,
                0.10f
            )
        );
    }

    public float GetHealth()
    {
        return health.health;
    }

    public float GetShield()
    {
        return shield.shield;
    }
}