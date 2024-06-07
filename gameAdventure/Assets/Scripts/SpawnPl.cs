using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPl : MonoBehaviour
{
    public GameObject platformPrefab;
    [SerializeField] private Transform _targetPlayer;

    void Update()
    {
        if (_targetPlayer.position.y >= 0 && Input.GetKeyDown(KeyCode.K))
        {
            GameObject platform = Instantiate(platformPrefab, new Vector3(_targetPlayer.position.x, _targetPlayer.position.y - 0.6f, transform.position.z), Quaternion.identity);
            Destroy(platform,1f);  
        }
    }
}
