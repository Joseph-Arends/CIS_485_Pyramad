using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code by: Joseph Arends

public class WallBreaker : MonoBehaviour
{
    // All this does is break walls
    // Only for singular walls
    public GameObject wall;
    private void OnCollisionEnter(Collision collision)
    {

        Destroy(wall);
    }
}
