using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private Transform respawn;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = respawn.transform.position;
            Physics.SyncTransforms();
        }
    }

}
