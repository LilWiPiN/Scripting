using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Update()
    {
        DestroyEnemy();
    }

    private void OnDestroy()
    {
        // Aumentamos la puntuación usando la instancia Singleton del GameManager
        if (GameManager.Instance != null)
        {
            GameManager.Instance.IncreaseScore(10);
        }
    }

    public void DestroyEnemy()
    {
        // Presiona clic izquierdo para recibir daño
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Destroy(gameObject);
        }
    }
}

