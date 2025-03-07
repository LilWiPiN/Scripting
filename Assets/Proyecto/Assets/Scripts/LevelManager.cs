using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;

public class LevelMannager : MonoBehaviour
{
    public void MainMenu()
    {
        MMSceneLoadingManager.LoadScene("MainMenu");
    }

    public void Tutorial()
    {
        MMSceneLoadingManager.LoadScene("Tutorial");
    }

    public void Credits()
    {
        MMSceneLoadingManager.LoadScene("Credits");
    }

    public void Level1()
    {
        MMSceneLoadingManager.LoadScene("Level1");
    }

    public void Level2()
    {
        MMSceneLoadingManager.LoadScene("Level2");
    }

    public void Level3()
    {
        MMSceneLoadingManager.LoadScene("Level3");
    }

    public void GameOver()
    {
        MMSceneLoadingManager.LoadScene("GameOver");
    }

    public void Win()
    {
        MMSceneLoadingManager.LoadScene("Win");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}