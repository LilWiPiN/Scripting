using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // La instancia única del Singleton
    public static GameManager Instance { get; private set; }
    public TextMeshProUGUI scoreText;

    // Método Awake se ejecuta al iniciar el script
    private void Awake()
    {
        // Verificamos si ya existe una instancia del GameManager
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // Destruimos esta instancia si ya existe otra
            return;
        }

        // Asignamos esta instancia y la marcamos para que no se destruya al cambiar de escena
        Instance = this;
        DontDestroyOnLoad(gameObject);

        IncreaseScore(0);
    }

    // Un método de ejemplo que podría utilizarse en la mecánica del juego
    public void IncreaseScore(int amount)
    {
        // Lógica para aumentar el puntaje
        scoreText.text = "Score: " + amount;
    }
}
