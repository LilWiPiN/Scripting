public abstract class AttackDecorator : IAttack
{
    protected IAttack decoratedAttack;

    public AttackDecorator(IAttack attack)
    {
        decoratedAttack = attack;
    }

    public virtual void Attack()
    {
        decoratedAttack.Attack();
    }
}
