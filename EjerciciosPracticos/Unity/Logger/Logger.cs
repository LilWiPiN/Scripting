using System.IO;
using UnityEngine;

public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();
    private string _logFilePath;

    // Propiedad pública para acceder a la instancia Singleton
    public static Logger Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }
    }

    // Constructor privado para evitar instancias externas
    private Logger()
    {
        // Define la ruta del archivo de log
        _logFilePath = Path.Combine(Application.persistentDataPath, "log.txt");

        // Crea el archivo si no existe
        if (!File.Exists(_logFilePath))
        {
            File.Create(_logFilePath).Dispose();
        }
    }

    // Método para registrar mensajes
    public void Log(string message)
    {
        string logMessage = $"{System.DateTime.Now}: {message}";

        lock (_lock)
        {
            File.AppendAllText(_logFilePath, logMessage + "\n");
        }

        Debug.Log(logMessage); // También se muestra en la consola de Unity
    }

    // Método para limpiar el archivo de log
    public void ClearLog()
    {
        lock (_lock)
        {
            File.WriteAllText(_logFilePath, string.Empty);
        }
    }
}


