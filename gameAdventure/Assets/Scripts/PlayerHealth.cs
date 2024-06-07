using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 15f;
    //public GameObject deathEffect;

    public void TakeDamagePlayer(int damage)
    {
        health -= damage;
        
    }

    public void Health(int h)
    {
        health = h;
    }
}
