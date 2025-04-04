using UnityEngine;

public class CombatSystemFacade : MonoBehaviour
{
    private AnimationController animationController;
    private SoundController soundController;
    private HealthController healthController;
    private DamageCalculator damageCalculator;

    private void Awake()
    {
        // Busca y asigna los componentes
        animationController = GetComponent<AnimationController>();
        soundController = GetComponent<SoundController>();
        healthController = GetComponent<HealthController>();
        damageCalculator = GetComponent<DamageCalculator>();
    }

    public void Attack(int baseDamage)
    {
        int damage = damageCalculator.CalculateDamage(baseDamage);
        animationController.PlayAttackAnimation();
        soundController.PlayAttackSound();
        healthController.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        animationController.PlayDamageAnimation();
        soundController.PlayDamageSound();
        healthController.TakeDamage(damage);
    }
}
