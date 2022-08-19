using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MagneticGun : MonoBehaviour
{
    [SerializeField] private InputActionReference magneticShoot;
    [SerializeField] private RotateAroundActivator rotateAroundActivator;

    private void OnEnable()
    {
        print("Setting up all");
        magneticShoot.action.performed += MagneticPerformed;
        magneticShoot.action.canceled += MagneticCanceled;
    }
    private void OnDisable()
    {
        magneticShoot.action.performed -= MagneticPerformed;
        magneticShoot.action.canceled -= MagneticCanceled;
    }

    private void MagneticPerformed(InputAction.CallbackContext obj)
    {
        rotateAroundActivator.StartRotation();
    }
    private void MagneticCanceled(InputAction.CallbackContext obj)
    {
        rotateAroundActivator.StopRotation();
    }
}
