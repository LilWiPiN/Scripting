using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{

    [SerializeField] private GameObject buttonBack;
    [SerializeField] private GameObject menuPause;

    public void Pause()
    {
        buttonBack.SetActive(false);
        menuPause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Continue()
    {
        Time.timeScale = 1f;
        buttonBack.SetActive(false);
        menuPause.SetActive(true);
    }
}
