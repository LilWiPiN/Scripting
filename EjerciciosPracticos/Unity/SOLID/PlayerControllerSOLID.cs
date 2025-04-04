using UnityEngine;

public class PlayerControllerSOLID : MonoBehaviour
{
    public float moveSpeed = 5f;
    //public PlayerHealthSOLID playerHealth;
    private IWeapon equippedWeapon;

    private void Start()
    {
        // Inicializa la salud del jugador
        //playerHealth.Initialize(100);
        // Equipar una espada por defecto
        equippedWeapon = GetComponentInChildren<IWeapon>();
    }

    private void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space)) // Presiona espacio para atacar
        {
            Attack();
        }
    }

    private void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0);
        transform.position += movement * moveSpeed * Time.deltaTime;
    }

    private void Attack()
    {
        if (equippedWeapon != null)
        {
            equippedWeapon.Use();
        }
    }
}

