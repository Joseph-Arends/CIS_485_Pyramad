using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCeiling : MonoBehaviour
{

    /// <summary>
    /// Very simple script used for activating an object
    /// </summary>
    public GameObject ceiling;
    private void OnMouseDown()
    {
        ceiling.GetComponent<CeilingDrop>().isMoving = true;
    }
}
