using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundActivator : MonoBehaviour
{
    [SerializeField] private List<GameObject> rotableGameobjects = new List<GameObject>();
    public Transform rotationTarget;
    public Transform rotationParent;
    public bool isDetectionStarted;

    private void Update()
    {
        if (isDetectionStarted)
            ActivateRotationAround();        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == GameTags.Rotable && isDetectionStarted)
        {            
            rotableGameobjects.Add(other.gameObject);
        }
    }
    private void OnDestroy()
    {
        DeactivateRotationAround();
    }
    private void ActivateRotationAround()
    {
        RotateAround rotateAround;
        foreach (GameObject rotableGameobject in rotableGameobjects)
        {
            rotateAround = rotableGameobject.GetComponent<RotateAround>();
            if (rotateAround)
            {
                rotateAround.rotateTarget = rotationTarget;
                rotateAround.StartRotation();                
            }
            rotableGameobject.transform.SetParent(rotationParent);
        }
    }
    private void DeactivateRotationAround()
    {
        RotateAround rotateAround;
        foreach (GameObject rotableGameobject in rotableGameobjects)
        {
            rotateAround = rotableGameobject.GetComponent<RotateAround>();
            if (rotateAround)
            {
                rotateAround.rotateTarget = null;
                rotateAround.StopRotation();
            }
            rotateAround = null;
            rotableGameobject.transform.SetParent(null);
        }
    }

    public void StartRotation()
    {
        isDetectionStarted = true;
    }
    public void StopRotation()
    {
        isDetectionStarted = false;
        DeactivateRotationAround();
        ReleaseAllObjects();
    }

    public void ReleaseAllObjects() => rotableGameobjects.Clear(); 

}
