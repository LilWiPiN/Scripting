using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private PlayerDelegadosObserver player;
    [SerializeField] private TextMeshProUGUI healthText;

    private void Awake()
    {
        healthText.text = "Player health: 100";
    }

    private void OnEnable()
    {
        // Nos suscribimos al evento
        player.HealthChanged += UpdateHealthDisplay;
    }

    private void OnDisable()
    {
        // Nos desuscribimos del evento para evitar errores cuando el objeto se destruye
        player.HealthChanged -= UpdateHealthDisplay;
    }

    private void UpdateHealthDisplay(int currentHealth)
    {
        healthText.text = "Player health: " + currentHealth;
        // Aquí podrías actualizar la barra de salud u otros elementos de la UI
    }
}
