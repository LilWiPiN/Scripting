using System;

public class ConcreteObserver : IObserver
{
    private string observerName;

    public ConcreteObserver(string name)
    {
        observerName = name;
    }

    public void Update(string state)
    {
        Console.WriteLine($"{observerName} ha sido notificado del nuevo estado: {state}");
    }
}
