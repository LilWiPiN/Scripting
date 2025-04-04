using UnityEngine;

public class Player : MonoBehaviour
{
    private IAttack currentAttack;

    void Start()
    {
        // Inicialmente, el jugador tiene un ataque básico
        currentAttack = new BasicAttack();

        // Aplica un decorador de daño extra
        currentAttack = new DamageBoostDecorator(currentAttack);

        // Aplica un decorador de velocidad extra
        currentAttack = new SpeedBoostDecorator(currentAttack);

        // Ahora el disparo tiene ambos efectos: daño extra y velocidad extra
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            currentAttack.Attack();
        }
    }
}
