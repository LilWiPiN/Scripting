using System;
using System.IO;

public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();
    private string logFilePath = "log.txt";

    // Constructor privado para evitar la creación de instancias externas
    private Logger()
    {
        // Crear o limpiar el archivo de log al iniciar
        File.WriteAllText(logFilePath, "Log de mensajes:\n");
    }

    // Método público para obtener la única instancia del Logger
    public static Logger Instance
    {
        get
        {
            lock (_lock) // Asegurar que solo un hilo pueda acceder a la instancia a la vez
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
            }
            return _instance;
        }
    }

    // Método para registrar mensajes en el archivo de texto
    public void Log(string message)
    {
        lock (_lock)
        {
            File.AppendAllText(logFilePath, DateTime.Now + ": " + message + "\n");
        }
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        Logger logger = Logger.Instance;
        logger.Log("Iniciando la aplicación...");
        logger.Log("Error de conexión a la base de datos");
        logger.Log("Finalizando la aplicación...");
    }
}
