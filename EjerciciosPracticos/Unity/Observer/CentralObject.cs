using UnityEngine;

public class CentralObject : Subject
{
    // Ejemplo de un evento que activa la notificación
    private void Update()
    {
        // Notificar cuando se presione el clic izquierdo
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            NotifyObservers();
        }
    }
}
