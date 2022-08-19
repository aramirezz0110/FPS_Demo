using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class SimpleBulletShooter : MonoBehaviour
{
    [SerializeField] private InputActionReference simpleShoot;
    [SerializeField] private Transform bulletOrigin;
    [SerializeField] private GameObject bullet;
    private void OnEnable()
    {
        print("Setting up all");
        simpleShoot.action.performed += ShootPerformed;
        simpleShoot.action.canceled += ShootCanceled;
    }
    private void OnDisable()
    {
        simpleShoot.action.performed -= ShootPerformed;
        simpleShoot.action.canceled -= ShootCanceled;
    }
    private void ShootPerformed(InputAction.CallbackContext obj)
    {
        Instantiate(bullet, bulletOrigin.position, bulletOrigin.rotation);
    }
    private void ShootCanceled(InputAction.CallbackContext obj)
    {
        
    }

    

    
}
