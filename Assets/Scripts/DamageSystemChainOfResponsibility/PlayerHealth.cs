using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    ShieldHandler shield;
    ArmorHandler armor;
    HealthHandler health;

    void Start()
    {
        shield = new ShieldHandler();
        armor = new ArmorHandler();
        health = new HealthHandler();

        shield.SetNext(armor);
        armor.SetNext(health);
    }

    public void TakeDamage(float dmg)
    {
        shield.HandleDamage(ref dmg);

        if (health.health <= 0)
        {
            Debug.Log("GAME OVER");
        }
    }
}