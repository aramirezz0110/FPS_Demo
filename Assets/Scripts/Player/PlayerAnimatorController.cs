using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimatorController : MonoBehaviour
{
    [Header("Animator")]
    [SerializeField] private Animator animator;
    [Header("Input Action References")]
    [SerializeField] private InputActionReference movementAction;
    [SerializeField] private InputActionReference shootAction;
    
    private void OnEnable()
    {
        movementAction.action.performed += MovementPerformed;
        movementAction.action.canceled += MovementCanceled;        
    }
    private void OnDisable()
    {
        movementAction.action.performed -= MovementPerformed;
        movementAction.action.canceled -= MovementCanceled;
    }

    private void MovementPerformed(InputAction.CallbackContext obj)
    {
        animator.SetFloat(GameAnimationParameters.Walking, 1);        
    }
    private void MovementCanceled(InputAction.CallbackContext obj)
    {        
        animator.SetFloat(GameAnimationParameters.Walking, 0);
    }

    
}
