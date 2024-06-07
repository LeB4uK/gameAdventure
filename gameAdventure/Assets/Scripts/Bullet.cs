using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        EnemyBoss enemyBoss = hitInfo.GetComponent<EnemyBoss>();
        if(enemy != null)
        {
            enemy.TakeDamage(2);
        }
        if (enemyBoss != null)
        {
            enemyBoss.TakeDamageBoss(2);
        }
   
        Destroy(gameObject);
    }

}
