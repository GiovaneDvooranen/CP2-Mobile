public class HealthHandler : DamageHandler
{
    public float health = 100;

    public override void HandleDamage(ref float damage)
    {
        health -= damage;
    }
}