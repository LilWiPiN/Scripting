public class Singleton
{
    private static Singleton instance = null;

    // Constructor privado
    private Singleton() { }

    // Método estático que devuelve la única instancia
    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();  // Si no existe, la crea
            }
            return instance;  // Siempre devuelve la misma instancia
        }
    }
}
