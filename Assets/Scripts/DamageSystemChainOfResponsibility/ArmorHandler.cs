public class ArmorHandler : DamageHandler
{
    public override void HandleDamage(ref float damage)
    {
        damage *= 0.8f;

        next?.HandleDamage(ref damage);
    }
}