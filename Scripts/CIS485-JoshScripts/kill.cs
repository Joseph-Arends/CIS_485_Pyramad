using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
      [SerializeField] private Transform player;
      [SerializeField] private Transform respawnPoint;
    CharacterController cc;

    private void Start()
    {
        cc = player.GetComponent<CharacterController>();
    }
    private void OnTriggerEnter(Collider other)
     {
        Debug.Log("worked");
        cc.enabled = false;
        player.transform.position = respawnPoint.transform.position;
        cc.enabled = true;

    }
}

