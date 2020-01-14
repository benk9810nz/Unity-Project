using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string TitleScene;
    public string LevelScene;
    public GameObject deadCanvas;

    public void SelectTitle()
    {
        SceneManager.LoadSceneAsync(TitleScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadLevel()
    {
        SceneManager.LoadSceneAsync(LevelScene);
    }
}
