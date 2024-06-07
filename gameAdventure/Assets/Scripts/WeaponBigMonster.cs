using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBigMonster : MonoBehaviour
{
    public Transform firePoint1, firePoint2, firePoint3, firePoint4;
    public GameObject bulletPrefab;
    public float timeToSpawn = 3f;
    float timer;

    private void Start()
    {
        timer = timeToSpawn;
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
        Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
        Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
        Instantiate(bulletPrefab, firePoint3.position, firePoint3.rotation);
        Instantiate(bulletPrefab, firePoint4.position, firePoint4.rotation);
    }
}
