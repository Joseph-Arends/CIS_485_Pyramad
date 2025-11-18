using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code by: Joseph Arends

public class Elevator : MonoBehaviour
{
    public Transform top;
    public Transform bottom;
    public GameObject elevator;
    float speed = 0.15f;
    bool isMoving;
    bool isUp;
    Vector3 topPosition;
    Vector3 bottomPosition;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        topPosition = new Vector3(0.97f, 100f, -40.9f);
        bottomPosition = new Vector3(0.97f, 0.2f, -40.9f);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (isDown == true)
        {
            speed += Time.deltaTime / 10;
            elevator.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
        }*/

        if (isMoving == true)
        {
            float step = speed * Time.deltaTime;
            elevator.gameObject.transform.position = Vector3.Lerp(elevator.gameObject.transform.position, top.position, step);
            //transform.Translate(Vector3.up * Time.deltaTime);
        }
        if (elevator.gameObject.transform.localPosition.y >= top.localPosition.y)
        {
            isMoving = false;
        }

        
        /*else if (isDown == false)
        {
            while (elevator.gameObject.transform.localPosition.y > 0.2f)
            {
                float step = speed * Time.deltaTime;
                elevator.gameObject.transform.position = Vector3.MoveTowards(topPosition, bottomPosition, step);
                //transform.Translate(Vector3.up * Time.deltaTime);
            }
        }*/

    }
    private void OnMouseDown()
    {
        if (isMoving == true)
        {
            isMoving = false;
        }
        else if (isMoving == false)
        {
            isMoving = true;
        }
        //MoveElevator();
    }

    void MoveElevator()
    {
        Debug.Log(isMoving);
        if (isMoving == true)
        {
            while (elevator.gameObject.transform.localPosition.y < 99)
            {
                speed += Time.deltaTime / 10;
                elevator.gameObject.transform.position = Vector3.MoveTowards(bottomPosition, topPosition, speed);

                //transform.Translate(Vector3.up * Time.deltaTime);
            }
        }

        else if (isMoving == false)
        {
            while (elevator.gameObject.transform.localPosition.y > 0.2f)
            {
                speed += Time.deltaTime / 10;
                elevator.gameObject.transform.position = Vector3.MoveTowards(topPosition, bottomPosition, speed);
                //transform.Translate(Vector3.up * Time.deltaTime);
            }
        }
    }
}
