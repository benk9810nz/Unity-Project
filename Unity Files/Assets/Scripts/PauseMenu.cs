using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public string TitleScene;
    public bool isPaused;
    public GameObject pauseCanvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            pauseCanvas.SetActive(true);
            Time.timeScale = 0f;
            
        }
        else
        {
            pauseCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void SelectTitle()
    {
        SceneManager.LoadSceneAsync(TitleScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
