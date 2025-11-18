using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code by: Joseph Arends

public class UnlockThrowPower : MonoBehaviour
{
    // This is a simple script for giving the player access to the projectile power
    public GameObject player;


    private void OnMouseDown()
    {
        Debug.Log("Workging");
        player.GetComponent<Player_Projectile_Controller>().powerUnlocked = true;
        
        Destroy(gameObject);
    }
    
}
