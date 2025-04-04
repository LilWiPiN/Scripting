using UnityEngine;

public class SpeedBoostDecorator : AttackDecorator
{
    public SpeedBoostDecorator(IAttack attack) : base(attack) { }

    public override void Attack()
    {
        base.Attack();
        IncreaseSpeed();
    }

    private void IncreaseSpeed()
    {
        Debug.Log("Speed Boost Applied!");
        // Lógica para incrementar la velocidad del ataque
    }
}
