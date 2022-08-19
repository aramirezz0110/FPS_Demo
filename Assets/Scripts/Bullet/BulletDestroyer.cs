using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    [SerializeField] private float bulletLifetime=4f;
    private void Start()=> Destroy(gameObject, bulletLifetime);

}
