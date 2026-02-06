using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;
using System;
using System.Collections;

public class NPCWaypointSystem : MonoBehaviour
{
    public List<Transform> waypoints;
    public float stoppingRadius = 0.5f;
    private int currentWaypoint = 0;
    private NavMeshAgent agent;

    private bool switching;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = waypoints[currentWaypoint].position;

        switching = false;
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypoint].position) < stoppingRadius && switching == false)
        {

            StartCoroutine(ChangeWaypointWait(UnityEngine.Random.Range(3,10)));

        }

    }

    IEnumerator ChangeWaypointWait(float waitTime)
    {
        switching = true;
        GetComponent<navagentCustomRotation>().enabled = false;
        yield return new WaitForSeconds(waitTime);
        currentWaypoint = (currentWaypoint + 1) % waypoints.Count;
        agent.destination = waypoints[currentWaypoint].position;
        GetComponent<navagentCustomRotation>().enabled = true;
        switching = false;

    }
}
