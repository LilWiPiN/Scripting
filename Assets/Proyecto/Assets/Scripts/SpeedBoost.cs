using System.Collections;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float speedIncrease = 5f; 
    public float duration = 5f; 

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();
    //        if (playerMovement != null)
    //        {
    //            StartCoroutine(ApplySpeedBoost(playerMovement));
    //        }
    //        gameObject.SetActive(false); 
    //    }
    //}

    //private IEnumerator ApplySpeedBoost(PlayerMovement player)
    //{
    //    player.speed += speedIncrease;
    //    yield return new WaitForSeconds(duration);
    //    player.speed -= speedIncrease;
    //    Destroy(gameObject);
    //}
}
