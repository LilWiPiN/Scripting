using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TextMeshProUGUI healthText;

    private void Start()
    {
        UpdateHealthDisplay(playerHealth.GetHealth());

        if (playerHealth != null)
        {
            // Suscribirse al evento
            playerHealth.OnHealthChanged += UpdateHealthDisplay;
        }
    }

    private void UpdateHealthDisplay(int newHealth)
    {
        healthText.text = "Health: " + newHealth;
    }

    private void OnDestroy()
    {
        // Desuscribirse del evento para evitar referencias colgantes
        if (playerHealth != null)
        {
            playerHealth.OnHealthChanged -= UpdateHealthDisplay;
        }
    }
}

