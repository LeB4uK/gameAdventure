using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnHealth : MonoBehaviour
{
    public GameObject healthPrefab;
    public float timeToSpawn = 5f;
    public float timer;
    public float minYPosition = 5, maxYPosition = 21, minXPosition = -9, maxXPosition = 9;

    private void Start()
    {
        timer = timeToSpawn;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = timeToSpawn;
            float randX1 = Random.Range(minXPosition, -3);
            float randX2 = Random.Range(-3, 3);
            float randX3 = Random.Range(3, maxXPosition);
            float randY1 = Random.Range(minYPosition, maxYPosition);
            float randY2 = Random.Range(minYPosition, maxYPosition);
            float randY3 = Random.Range(minYPosition, maxYPosition);
            GameObject health1 = Instantiate(healthPrefab,new Vector3(randX1,randY1,transform.position.z), Quaternion.identity);
            GameObject health2 = Instantiate(healthPrefab, new Vector3(randX2, randY2, transform.position.z), Quaternion.identity);
            GameObject health3 = Instantiate(healthPrefab, new Vector3(randX3, randY3, transform.position.z), Quaternion.identity);
            Destroy(health1, 5f);
            Destroy(health2, 5f);
            Destroy(health3, 5f);
        }
    }
}
