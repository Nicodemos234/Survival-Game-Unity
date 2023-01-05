using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject[] farms;
    public GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTrees", 0, 0.5F);

    }

    void SpawnTrees() {
        farms = GameObject.FindGameObjectsWithTag("Farm");
        if(farms.Length < 10) {
        Instantiate(tree, new Vector3(Random.Range(-15.0f, 15.0f), Random.Range(-15.0f, 15.0f), 0), Quaternion.identity);
        }
    }
   
}
