using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMonsters : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    float timeToSpawn = 1f;
    float timer;

    private void Start()
    {
        timer = 0.5f;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = timeToSpawn;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
