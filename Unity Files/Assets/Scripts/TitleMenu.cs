using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TitleMenu : MonoBehaviour
{
    public string startScene;
    public string CreditScene;
   
    // Start is called before the first frame update
    public void StartNewGame()
    {
        SceneManager.LoadSceneAsync(startScene);
    }

    public void Credits()
    {
        SceneManager.LoadSceneAsync(CreditScene);
    }

    public void QuitToReality()
    {
        Application.Quit();
    }
}
