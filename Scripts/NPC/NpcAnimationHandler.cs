using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.AI;


public class NpcAnimationHandler : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(agent.velocity.x + agent.velocity.y + agent.velocity.z) > .05)
        {
            animator.SetTrigger("isWalking");
            animator.speed = 1f;
        } else
        {
            animator.ResetTrigger("isWalking");
        }

    }
}
