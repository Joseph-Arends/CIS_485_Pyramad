using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code by: Joseph Arends

public class PlatformMovement : MonoBehaviour
{
    /// <summary>
    /// This is the script for making platforms move
    /// This was ORIGINALLY the script for both this AND actuall platform movement
    /// But changes had to be made to make things function correctly
    /// It's honestly a simple script.
    /// Just place this on the script you want to make as a switch
    /// Put the object you want to act as the moving object as the elevator variable in the inspector,
    /// Then you're good to go.
    /// </summary>
    public GameObject elevator;
    

    /*void Start()
    {
        isMoving = false;
        destinationOne = new Vector3(xPositionOne, yPositionOne, zPositionOne);
        destinationTwo = new Vector3(xPositionTwo, yPositionTwo, zPositionTwo);
        destinationOne = dOne.position;
        destinationTwo = dTwo.position;

        elevator.transform.position = destinationOne;
    }*

    // Update is called once per frame
    /*void FixedUpdate()
    {
        if (isMoving == true)
        {
            if (goToDOne == true)
            {
                float step = speed * Time.deltaTime;
                //elevator.gameObject.transform.position = Vector3.Lerp(elevator.gameObject.transform.position, destinationOne, step);
                elevator.gameObject.transform.position = Vector3.MoveTowards(elevator.gameObject.transform.position, destinationOne, step);
                //transform.Translate(Vector3.up * Time.deltaTime);
            }

            else if (goToDTwo == true)
            {
                float step = speed * Time.deltaTime;
                elevator.gameObject.transform.position = Vector3.MoveTowards(elevator.gameObject.transform.position, destinationTwo, step);
            }

            if (elevator.gameObject.transform.position == destinationOne)
            {
                Debug.Log("Moving");
                goToDOne = false;
                goToDTwo = true;

            }

            if (elevator.gameObject.transform.position == destinationTwo)
            {
                goToDOne = true;
                goToDTwo = false;

            }
        }


        
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("It's a hit");
        if (elevator.GetComponent<PlatformStick>().isMoving == true)
        {
            elevator.GetComponent<PlatformStick>().isMoving = false;
            elevator.GetComponent<PlatformStick>().goToDOne = false;
        }

        else if (elevator.GetComponent<PlatformStick>().isMoving == false)
        {
            elevator.GetComponent<PlatformStick>().isMoving = true;
            elevator.GetComponent<PlatformStick>().goToDOne = true;
        }
        
        //isMoving = true;
    }
}
