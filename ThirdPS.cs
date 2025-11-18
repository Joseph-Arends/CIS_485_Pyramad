using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPS : MonoBehaviour
{
    public GameObject thirdCam;
    public GameObject firstCam;
    public int camMode;

    void Update()
    {
        if (Input.GetButtonDown("Ctrl"))
        {
            if(camMode == 1) 
            {
                camMode = 0;
            }
            else 
            {
                camMode = 1;
            }
            CamChange();
        }
    }



    public void CamChange() 
    {
        if(camMode == 1) 
        {
            firstCam.SetActive(true);
            thirdCam.SetActive(false);
        }
        else 
        {
            firstCam.SetActive(false);
            thirdCam.SetActive(true);
        }
    }

    
}
