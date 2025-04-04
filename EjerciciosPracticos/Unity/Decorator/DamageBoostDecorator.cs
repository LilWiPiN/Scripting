using UnityEngine;

public class DamageBoostDecorator : AttackDecorator
{
    public DamageBoostDecorator(IAttack attack) : base(attack) { }

    public override void Attack()
    {
        base.Attack();
        AddDamage();
    }

    private void AddDamage()
    {
        Debug.Log("Extra Damage Applied!");
        // Lógica para incrementar el daño del ataque
    }
}
