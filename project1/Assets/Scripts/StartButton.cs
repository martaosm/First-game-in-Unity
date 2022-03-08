using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    
    public void LoadSceneByIndex(int indexOfScene)
    {
        SceneManager.LoadScene(indexOfScene);
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
