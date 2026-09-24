public abstract class DamageHandler
{
    protected DamageHandler next;

    public void SetNext(DamageHandler handler)
    {
        next = handler;
    }

    public abstract void HandleDamage(ref float damage);
}