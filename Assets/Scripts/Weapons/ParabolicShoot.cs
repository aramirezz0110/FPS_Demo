using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ParabolicShoot : MonoBehaviour
{
    [SerializeField] private InputActionReference shootAction;
    [SerializeField] private ParabolicShootConfig parabolicShootConfig;
    [SerializeField] private Transform bulletOrigin;    

    private Rigidbody bulletRigidBody;
    
    private void OnEnable()
    {
        shootAction.action.performed += ShootPerformed;
        shootAction.action.canceled += ShootCanceled;
    }
    private void OnDisable()
    {
        shootAction.action.performed -= ShootPerformed;
        shootAction.action.canceled -= ShootCanceled;
    }
    private void ShootPerformed(InputAction.CallbackContext obj)
    {
        bulletRigidBody = Instantiate(parabolicShootConfig.bullet, bulletOrigin.position, bulletOrigin.localRotation).GetComponent<Rigidbody>();
        if (bulletRigidBody)
        {
            bulletRigidBody.velocity = bulletOrigin.forward * parabolicShootConfig.bulletImpulse;
        }
    }
    private void ShootCanceled(InputAction.CallbackContext obj)
    {
        
    }
}
