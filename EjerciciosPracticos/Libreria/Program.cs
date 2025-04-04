using System;
using System.IO;
using System.Text;

public class Program
{
    public static void Main()
    {
        // Usamos un FileStream para abrir un archivo.
        FileStream fileStream = new FileStream("example.txt", FileMode.Create, FileAccess.Write);
        
        // Decoramos el FileStream con un BufferedStream para mejorar el rendimiento de escritura.
        BufferedStream bufferedStream = new BufferedStream(fileStream);
        
        // Ahora decoramos el BufferedStream con un StreamWriter para escribir texto de manera más sencilla.
        StreamWriter writer = new StreamWriter(bufferedStream, Encoding.UTF8);

        // Escribimos en el archivo.
        writer.WriteLine("¡Hola, patrón decorador!");
        
        // Cerramos el escritor, lo que también cerrará el BufferedStream y el FileStream.
        writer.Close();

        Console.WriteLine("Archivo creado y escrito con el patrón decorador.");
    }
}
