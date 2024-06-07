using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMonsterMirror : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    float timeToSpawn = 2f;
    float timer;

    private void Start()
    {
        timer = 1f;
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
