using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBulletMovement : MonoBehaviour    
{
    [SerializeField] private float speed = 10f;
    private void LateUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
