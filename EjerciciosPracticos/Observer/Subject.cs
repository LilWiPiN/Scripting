using System;
using System.Collections.Generic;

public class Subject
{
    private List<IObserver> observers = new List<IObserver>();
    private string state;

    public string State
    {
        get { return state; }
        set 
        {
            state = value;
            NotifyObservers(); // Notifica a todos los observadores cuando cambia el estado
        }
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(state);
        }
    }
}
