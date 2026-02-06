using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;



public class ConversationFunctions : MonoBehaviour
{

    public Transform conversationTarget;
    private NavMeshAgent _agent;

    public bool isPlayer;

    private Animator _animator;





    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();


    }

    private void OnTriggerEnter(Collider collision)
    {
        if (isPlayer)
        {
            if (collision.gameObject.tag == "NPC")
            {
                conversationTarget = collision.gameObject.transform;
            }
                
            
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        if (isPlayer)
        {
            conversationTarget = null;
        }
        
    }


    public void ConvoStart()
    {
        _agent.isStopped = true;

        StartCoroutine(LookAtConversant(0.5f));

    }

    public void ConvoEnd()
    {
        _agent.isStopped = false;


    }

    public void unCrouchForDog()
    {
        _animator.SetBool("isCrouching", false);
    }

    public void crouchForDog()
    {
        _animator.SetBool("isCrouching", true);
    }

    public void wave()
    {
        _animator.SetBool("isWaving", true);
        StartCoroutine(StopWaving(2f));

    }


    IEnumerator LookAtConversant(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if (conversationTarget != null) 
        {
            transform.rotation = Quaternion.LookRotation(conversationTarget.position - transform.position);
        } else
        {
            StartCoroutine(LookAtConversant(0.5f));
        }
        
    }

    IEnumerator StopWaving(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        _animator.SetBool("isWaving", false);
    }
}

