using UnityEngine;

public class ShieldHandler : DamageHandler
{
    public float shield = 50;

    public override void HandleDamage(ref float damage)
    {
        float absorbed =Mathf.Min(shield, damage);

        shield -= absorbed;

        damage -= absorbed;

        if (damage > 0) next?.HandleDamage(ref damage);
    }
}