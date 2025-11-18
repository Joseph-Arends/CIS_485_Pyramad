using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderController : MonoBehaviour
{
    public GameObject prefab;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;


    private void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);

    }
    public void SpawnObject()
    {
        Instantiate(prefab, transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}

