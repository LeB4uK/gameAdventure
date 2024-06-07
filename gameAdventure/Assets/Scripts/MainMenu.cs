using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Scenes(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }

    public void ExitGame()
    {
        Debug.Log("Game");
        Application.Quit();
    }
}
