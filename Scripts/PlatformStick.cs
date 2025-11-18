using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code by: Joseph Arends

public class PlatformStick : MonoBehaviour
{
    /// <summary>
    /// This is the main script for making platforms move and keeping the player on the platform
    /// You need the transforms for the two empty gameobjects(or real gameobjects, if that's what you want)
    /// Just place them in the variable slot in the inspector
    /// speed changes how fast it goes
    /// If it doesn't work, make sure the player has a rigidbody and the platform has a a box collider that extends past the object that is a trigger
    /// Make sure player uses FixedUpdate instead of regular Update as well.
    /// ALSO, make sure player has the "Player" tag in the inspector as well
    /// </summary>
    public Transform dOne;
    public Transform dTwo;
    Vector3 destinationOne;
    Vector3 destinationTwo;
    public float speed = 0.15f;

    public bool isMoving = false;
    public bool goToDOne;
    public bool goToDTwo;


    void Start()
    {
        // Takes the Vector3 from the transforms that are meant to be the destinations for the platform
        destinationOne = dOne.position;
        destinationTwo = dTwo.position;

        transform.position = destinationOne;
    }

    // Make sure player also has FixedUpdate!!!
    private void FixedUpdate()
    {
        // Checks whether it's moving
        // Then goes from DOne to DTwo until isMoving is back to false
        if (isMoving == true)
        {
            if (goToDOne == true)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, destinationOne, step);
            }

            else if (goToDTwo == true)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, destinationTwo, step);
            }

            if (transform.position == destinationOne)
            {
                goToDOne = false;
                goToDTwo = true;

            }

            if (transform.position == destinationTwo)
            {
                goToDOne = true;
                goToDTwo = false;

            }
        }
    }

    // This is for player detection
    // Make sure player has the "Player" tag in the inspector
    
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("asdf");
        if (other.tag == "Player")
        {
            other.transform.SetParent(transform);
            Debug.Log(other.name);
        }
        //GameObject.Find("Player").transform.SetParent(transform);
        
        
    }

    

    // For player detection
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.SetParent(null);
            Debug.Log(other.name);
        }
        Debug.Log("Off");
        //other.transform.SetParent(null);
    }

    

    
}
