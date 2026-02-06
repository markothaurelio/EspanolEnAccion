using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.AI;

public class playerAnimationHandler : MonoBehaviour
{

    private Animator animator;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(agent.velocity.x + agent.velocity.y + agent.velocity.z) > .01)
        {
            animator.SetBool("isWalking", true);
            animator.speed = 1.5f;

        }
        else
        {
            animator.SetBool("isWalking", false);
        }

    }
}
