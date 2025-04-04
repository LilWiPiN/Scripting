using UnityEngine;

public class ExampleUsage : MonoBehaviour
{
    private void Start()
    {
        // Registrar un mensaje
        Logger.Instance.Log("El juego ha iniciado.");

        // Limpiar el archivo de log
        // Logger.Instance.ClearLog();
    }
}


