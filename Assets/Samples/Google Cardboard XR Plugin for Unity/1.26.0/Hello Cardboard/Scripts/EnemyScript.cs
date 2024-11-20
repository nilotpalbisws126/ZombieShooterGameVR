using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    private Transform goal;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GetComponent<Animation>().Play("Z_Walk_InPlace 1");

    }
    void Update()
    {
        goal = Camera.main.transform;
        agent.destination = goal.position;
    }
    
}
