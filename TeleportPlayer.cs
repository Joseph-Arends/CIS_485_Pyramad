using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code by: Joseph Arends

public class TeleportPlayer : MonoBehaviour
{
    // This is for teleporting the player
    // Place the player and the teleport location in the inspector
    // This is done through collision
    // This one is done with the presumption that the player has a character controller
    public GameObject Player;
    public GameObject teleportLocation;
    CharacterController cc;
    void Start()
    {
        cc = Player.GetComponent<CharacterController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == GameObject.FindGameObjectWithTag("Projectile"))
        {
            cc.enabled = false;
            
            Player.transform.position = teleportLocation.transform.position;
            cc.enabled = true;
        }
        
    }
}
