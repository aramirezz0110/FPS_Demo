using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ParabolicShoot : MonoBehaviour
{
    [SerializeField] private InputActionReference shootAction;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletOrigin;
    [SerializeField] private float bulletImpulse=2.0f;

    private Rigidbody bulletRigidBody;
    private void Start()
    {
        
    }
    private void OnEnable()
    {
        shootAction.action.performed += ShootPerformed;
        shootAction.action.canceled += ShootCanceled;
    }   

    private void ShootPerformed(InputAction.CallbackContext obj)
    {
        bulletRigidBody = Instantiate(bullet, bulletOrigin.position, bulletOrigin.localRotation).GetComponent<Rigidbody>();
        if (bulletRigidBody)
        {
            bulletRigidBody.velocity = bulletOrigin.forward * bulletImpulse;
        }
    }
    private void ShootCanceled(InputAction.CallbackContext obj)
    {
        
    }
}
