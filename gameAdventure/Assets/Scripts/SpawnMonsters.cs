using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class SpawnMonsters : MonoBehaviour
{
    public Transform _targetCamera;
    public GameObject monsterPrefab, monsterMirrorPrefab;
    public float timeToSpawn1 = 7, timeToSpawn2 = 7.3f, timeToSpawn3 = 7.6f, timeToSpawn4 = 7.9f, minXPosition = -9, maxXPosition = 9;
    public float minYPosition, maxYPosition;
    float timerMonstr1, timerMonstrMirror1, timerMonstr2, timerMonstrMirror2;

    private void Start()
    {
        timerMonstr1 = 1;
        timerMonstrMirror1 = 1.2f;
        timerMonstr2 = timeToSpawn3 = 1.4f;
        timerMonstrMirror2 = timeToSpawn4 = 1.6f;
    }
    
    void Update()
    {
        minYPosition = _targetCamera.position.y-2;
        maxYPosition = _targetCamera.position.y + 4;

        timerMonstr1 -= Time.deltaTime;
        if (timerMonstr1 < 0 && maxYPosition < 21)
        {
            timerMonstr1 = timeToSpawn1;
            float randX = Random.Range(minXPosition, -1);
            float randY = Random.Range(minYPosition, maxYPosition);
            GameObject monster = Instantiate(monsterPrefab, new Vector3(randX, randY+1, transform.position.z), Quaternion.identity);
            Destroy(monster, 8f);
        }

        timerMonstrMirror1 -= Time.deltaTime;
        if (timerMonstrMirror1 < 0 && maxYPosition < 21)
        {
            timerMonstrMirror1 = timeToSpawn2;
            float randX = Random.Range(1, maxXPosition);
            float randY = Random.Range(minYPosition, maxYPosition);
            GameObject monster = Instantiate(monsterMirrorPrefab, new Vector3(randX, randY, transform.position.z), Quaternion.identity);
            Destroy(monster, 8f);
        }

        timerMonstr2 -= Time.deltaTime;
        if (timerMonstr2 < 0 && maxYPosition < 21)
        {
            timerMonstr2 = timeToSpawn1;
            float randX = Random.Range(minXPosition, -1);
            float randY = Random.Range(minYPosition+1.7f, maxYPosition+2.2f);
            GameObject monster = Instantiate(monsterPrefab, new Vector3(randX, randY + 1, transform.position.z), Quaternion.identity);
            Destroy(monster, 8f);
        }

        timerMonstrMirror2 -= Time.deltaTime;
        if (timerMonstrMirror2 < 0 && maxYPosition < 21)
        {
            timerMonstrMirror2 = timeToSpawn2;
            float randX = Random.Range(1, maxXPosition);
            float randY = Random.Range(minYPosition+1.5f, maxYPosition+2f);
            GameObject monster = Instantiate(monsterMirrorPrefab, new Vector3(randX, randY+1, transform.position.z), Quaternion.identity);
            Destroy(monster, 8f);
        }

    }
}
