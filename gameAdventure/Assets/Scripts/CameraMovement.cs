using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _targetPlayer;
    
    void Update()
    {
        if (transform.position.y < _targetPlayer.position.y && _targetPlayer.position.y >= 4.9 ||
            transform.position.y > _targetPlayer.position.y && _targetPlayer.position.y >= 4.9)
        {
            transform.position = new Vector3(transform.position.x, _targetPlayer.position.y,transform.position.z);
        }

        var p = transform.position;
        if (p.y > 24) p.y = 24;
        transform.position = p;
    }
}
