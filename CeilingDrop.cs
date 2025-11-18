using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code by: Joseph Arends

public class CeilingDrop : MonoBehaviour
{
    /// <summary>
    /// This is for having an object do down  in one direction
    /// In this specific use case, it's for dropping the ceiling after a flag is raised.
    /// This is used in conjunction with ActivateCeiling to trigger the flag.
    /// </summary>
    public Transform dOne;
    public bool isMoving = false;
    public float speed = 0.15f;

    

    // Update is called once per frame
    void FixedUpdate()
    {
        // When flag is raised, drop the object
        if (isMoving == true)
        {
            float step = speed * Time.deltaTime;
            transform.position += Vector3.down * speed;
        }
    }
}
