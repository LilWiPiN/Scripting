using UnityEngine;

public class ObserverObject : MonoBehaviour, IObserver
{
    private void Start()
    {
        // Buscar al objeto central y registrarse como observador
        CentralObject centralObject = FindObjectOfType<CentralObject>();
        if (centralObject != null)
        {
            centralObject.AddObserver(this);
        }
    }

    public void OnNotify()
    {
        // Acciones a realizar cuando el sujeto emite una notificación
        Debug.Log(gameObject.name + " ha recibido una notificación del sujeto central.");
    }

    private void OnDestroy()
    {
        // Asegurarse de eliminarse como observador al destruir el objeto
        CentralObject centralObject = FindObjectOfType<CentralObject>();
        if (centralObject != null)
        {
            centralObject.RemoveObserver(this);
        }
    }
}
