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
    public float GetHealth()
    {
        return health.health;
    }

    public float GetShield()
    {
        return shield.shield;
    }
}