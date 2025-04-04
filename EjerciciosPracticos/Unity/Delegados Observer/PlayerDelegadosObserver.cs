using UnityEngine;

public class PlayerDelegadosObserver : MonoBehaviour
{
    public float moveSpeed = 5f;

    public delegate void OnHealthChanged(int currentHealth);
    public event OnHealthChanged HealthChanged;

    private int health = 100;

    private void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            TakeDamage(5);
        }
    }

    private void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0);
        transform.position += movement * moveSpeed * Time.deltaTime;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        health = Mathf.Max(health, 0);

        // Llamamos al evento cuando se produce un cambio en la salud
        if (HealthChanged != null)
        {
            HealthChanged(health);
        }
    }
}
