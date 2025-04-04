// Interfaz para los Observers
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    void OnNotify(); // Método que se llamará cuando el sujeto emita una notificación
}

// Clase base para el Subject
public class Subject : MonoBehaviour
{
    private List<IObserver> observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    // Método para notificar a todos los observadores
    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.OnNotify();
        }
    }
}
