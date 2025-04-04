using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Delegado y evento para la salud
    public delegate void HealthChanged(int newHealth);
    public event HealthChanged OnHealthChanged;

    private int health = 100;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) // Presiona espacio para recibir daño
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        health = Mathf.Max(health, 0); // Evitar salud negativa

        // Invocar el evento
        OnHealthChanged?.Invoke(health);
    }

    public int GetHealth()
    {
        return health;
    }
}

