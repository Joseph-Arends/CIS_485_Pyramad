using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject relic;

    void OnTriggerEnter(Collider other)
    {
        relic.SetActive(false);
    }
}
