using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code by: Joseph Arends

public class RotateObject : MonoBehaviour
{
    /// <summary>
    /// This is for the rotating object mechanic I used in the Puzzle Room level
    /// User picks an integer choice, rotation speed, and whether it is already rotating in the inspector
    /// Place the rotating game object in the inspector
    /// The rotation is started/stopped whenever collision is made with a trigger object
    /// </summary>
    public GameObject rotatingObject;
    public bool xAxis;
    public bool yAxis;
    public bool zAxis;
    public float rotationMagnitude;
    public float rotationSpeed;
    public int rotationChoice;

    // 0 is x axis
    // 1 is y axis
    // 2 is z axis
    private void FixedUpdate()
    {
        switch(rotationChoice)
        {
            case 0:
                if (xAxis == true)
                {
                    rotatingObject.transform.RotateAround(rotatingObject.transform.position, Vector3.right, rotationSpeed * Time.deltaTime);
                }
                break;

            case 1:
                if(yAxis == true)
                {
                    rotatingObject.transform.RotateAround(rotatingObject.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
                }
                break;

            case 2:
                if (zAxis == true)
                {
                    rotatingObject.transform.RotateAround(rotatingObject.transform.position, Vector3.forward, rotationSpeed * Time.deltaTime);
                }
                break;

        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        xAxis = !xAxis;
        yAxis = !yAxis;
        zAxis = !zAxis;
        
    }
}
