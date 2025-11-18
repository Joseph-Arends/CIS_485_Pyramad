using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) { Resume(); }
            else { PauseB(); }
        }
    }

    private void PauseB()
    {
        throw new NotImplementedException();
    }

    private void Resume()
    {
        throw new NotImplementedException();
    }
}
