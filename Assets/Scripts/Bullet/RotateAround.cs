using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider), typeof(Rigidbody))]
public class RotateAround : MonoBehaviour
{
    public RotateAxis _rotateAxis;
    public Transform rotateTarget;
    public float rotationSpeed = 30;
    public float rotationRadius = 1f;
    [SerializeField] private bool startRotation;

    private Rigidbody _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void LateUpdate()
    {
        if (startRotation)
            RotateAroundObject();
    }
    private void RotateAroundObject()
    {
        if (rotateTarget)
        {
            _rigidbody.useGravity = false;
            transform.RotateAround(rotateTarget.position, GetRotationAxis(), rotationSpeed * Time.deltaTime);
        }
    }
    public void StartRotation()
    {
        startRotation = true;
        _rigidbody.useGravity = false;
    }
    public void StopRotation()
    {
        startRotation = false;
        _rigidbody.useGravity = true;
    }
    public void SetRotationAxis(RotateAxis rotateAxis)=> _rotateAxis = rotateAxis;
    private Vector3 GetRotationAxis()
    {
        switch (_rotateAxis)
        {
            case RotateAxis.XAxis: return new Vector3(rotationRadius, 0, 0);
            case RotateAxis.YAxis: return new Vector3(0, rotationRadius, 0);
            case RotateAxis.ZAxis: return new Vector3(0, 0, rotationRadius);
            default: return new Vector3(1, 0, 0);
        }
    }
}
