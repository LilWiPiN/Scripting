// Controlador de daño
using UnityEngine;

public class DamageCalculator : MonoBehaviour
{
    public int CalculateDamage(int baseDamage)
    {
        int finalDamage = baseDamage + Random.Range(0, 10);
        Debug.Log($"Damage calculated: {finalDamage}");
        return finalDamage;
    }
}