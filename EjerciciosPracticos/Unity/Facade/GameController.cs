using UnityEngine;

public class GameController : MonoBehaviour
{
    public CombatSystemFacade combatSystem;

    private void Start()
    {
        // Realiza un ataque con un daño base de 10
        combatSystem.Attack(10);
    }
}
