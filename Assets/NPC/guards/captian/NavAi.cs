using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAi : MonoBehaviour
{
    public GameObject theDestination;
    NavMeshAgent theAgent;

    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        theAgent.SetDestination(theDestination.transform.position);
    }

}
