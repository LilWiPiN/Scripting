using System;

class Publisher
{
    // Definición del delegado
    public delegate void Notify();  

    // Definición del evento
    public event Notify OnNotify;

    public void DoSomething()
    {
        Console.WriteLine("Haciendo algo...");
        OnNotify?.Invoke(); // Invoca el evento
    }
}

class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        publisher.OnNotify += Respond; // Se suscribe al evento
    }

    private void Respond()
    {
        Console.WriteLine("¡El evento ha sido recibido!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();
        
        subscriber.Subscribe(publisher);
        publisher.DoSomething();
    }
}
