using UnityEngine;

public class PlayerHealthSOLID : MonoBehaviour
{
    private int health;

    public void Initialize(int initialHealth)
    {
        health = initialHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0) health = 0;
        Debug.Log($"Health: {health}");
    }

    public int GetHealth()
    {
        return health;
    }
}
