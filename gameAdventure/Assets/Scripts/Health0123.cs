using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health0123 : MonoBehaviour
{
    public GameObject Health0, Health1, Health2, Health3;
    public PlayerHealth player;

    void Update()
    {
        if (player.health <= 15 && player.health >=10)
        {
            Health3.SetActive(true);
            Health2.SetActive(false);
            Health1.SetActive(false);
            Health0.SetActive(false);
        }

        else if(player.health < 10 && player.health >= 5)
        {
            Health3.SetActive(false);
            Health2.SetActive(true);
            Health1.SetActive(false);
            Health0.SetActive(false);
        }

        else if (player.health < 5 && player.health >= 1)
        {
            Health3.SetActive(false);
            Health2.SetActive(false);
            Health1.SetActive(true);
            Health0.SetActive(false);
        }

        else if (player.health < 1)
        {
            Health3.SetActive(false);
            Health2.SetActive(false);
            Health1.SetActive(false);
            Health0.SetActive(false);
        }
    }
}
