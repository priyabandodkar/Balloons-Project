using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMoveTo : MonoBehaviour
{
    public Transform waypoint, goal;
    private UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = waypoint.position;
    }

    void Update()
    {
        if(Vector3.Distance(waypoint.position, transform.position) <= 3.0f)
        {
            agent.destination = goal.position;
        }
    }
}
