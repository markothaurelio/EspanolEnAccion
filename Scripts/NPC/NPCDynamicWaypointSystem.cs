using UnityEngine;
using UnityEngine.AI;

public class NPCDynamicWaypointSystem : MonoBehaviour
{
    public Transform waypoint;
    public float stoppingRadius = 0.5f;
    private NavMeshAgent agent;
    public bool stopFollowingWhenReached;

    private bool hasReached;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = waypoint.position;


        hasReached = false;



    }

    void Update()
    {

        if (stopFollowingWhenReached)
        {
            if (Vector3.Distance(transform.position, waypoint.position) < stoppingRadius)
            {
                agent.isStopped = true;
                hasReached = true;
            }
            else if (hasReached == false)
            {
                agent.isStopped = false;
                agent.destination = waypoint.position;
            }

        }  else
        {
            if (Vector3.Distance(transform.position, waypoint.position) < stoppingRadius)
            {
                agent.isStopped = true;
            }
            else
            {
                agent.isStopped = false;
                agent.destination = waypoint.position;
            }

        }

    }
}
