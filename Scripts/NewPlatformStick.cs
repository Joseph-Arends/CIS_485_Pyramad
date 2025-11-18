using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlatformStick : MonoBehaviour
{
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
