using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoulder : MonoBehaviour
{
    public Transform Spawnpoint;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public Rigidbody RigidPrefab;



    private void OnTriggerEnter()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        RigidPrefab = (Instantiate(RigidPrefab, Spawnpoint.position, Spawnpoint.rotation));
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
