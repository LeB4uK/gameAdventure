using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnTrees : MonoBehaviour
{
    public GameObject treePrefab;

    void Update()
    {
            GameObject tree = Instantiate(treePrefab, transform.position, quaternion.identity);
            Destroy(tree, 10f);
        
    }
}
