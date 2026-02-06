using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navagentCustomRotation : MonoBehaviour
{
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
    }

    private void LateUpdate()
    {
        //    if (agent.velocity.sqrMagnitude > Mathf.Epsilon)
        //     {
        //       transform.rotation = Quaternion.LookRotation(agent.velocity.normalized);
        //  }

        var projected = agent.velocity;
        projected.y = 0f;
            
        if (!Mathf.Approximately(projected.sqrMagnitude, 0f))
            transform.rotation = Quaternion.LookRotation(projected.normalized);



    }

}
