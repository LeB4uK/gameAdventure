using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameIsOver : MonoBehaviour
{
    public GameObject overUI;
    public PlayerHealth player;

    void Update()
    {
        if (player.health <= 0)
        {    
            Over();
            player.health = 0.1f;
        }

    }

    public void Over()
    {
        overUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        overUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
