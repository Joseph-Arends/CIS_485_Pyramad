using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aPlayer;
    NavMeshAgent monster;
    void Start()
    {
        monster = GetComponent<NavMeshAgent>();   
    }

    // Update is called once per frame
    void Update()
    {
        monster.SetDestination(aPlayer.transform.position);
    }
}
