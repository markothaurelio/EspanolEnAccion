
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerClickMovement : MonoBehaviour
{
    public Camera playerCam;

    private RaycastHit hit;

    private NavMeshAgent agent;

    private string groundTag = "Ground";



    private BoxCollider boxColliderToIgnore;



    private void Start()
    {

        agent = GetComponent<NavMeshAgent>();

        boxColliderToIgnore = GetComponent<BoxCollider>();


        // animator.Play("Idle");


    }


    private void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {

            Ray ray = playerCam.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 5);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.CompareTag(groundTag))
                {
                    agent.SetDestination(hit.point);
                }
            }
        }




    }

}
