using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
    public void Use()
    {
        Debug.Log("Swinging the sword!");
        // Lógica para el ataque con espada
    }
}
