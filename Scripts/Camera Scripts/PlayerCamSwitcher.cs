using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCamSwitcher : MonoBehaviour
{

    [SerializeField]
    private InputAction action;

    private Animator animator;
    
    private bool vcam_1 = true;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {

        action.performed += _ => SwitchState();


       

    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    private void SwitchState()
    {
        if (vcam_1)
        {
            animator.Play("vcam_2");
        } else
        {
            animator.Play("vcam_1");
        }

        vcam_1 = !vcam_1;

    }

    public void SwitchToConvoCam()
    {
        if (vcam_1)
        {
            animator.Play("vcam_3");
        }
    }

    public void SwitchToPlayerCam()
    {
        if (vcam_1)
        {
            animator.Play("vcam_1");
        }
    }
}
