using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private int c = -2;
    private int d = 0;
    public GameObject skyPrefab;
    private GameObject sky;
    [SerializeField] private Transform _targetPlayer;

    void Update()
    {
        if (_targetPlayer.position.y >= c && d<30)
        {
            sky = Instantiate(skyPrefab, new Vector3(transform.position.x, transform.position.y + d, transform.position.z), Quaternion.identity);
            c += 5;
            d += 10;
        }
    }
}
