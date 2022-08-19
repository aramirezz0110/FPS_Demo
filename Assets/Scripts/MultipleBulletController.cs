using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleBulletController : MonoBehaviour
{
    [SerializeField] private GameObject multipleBulletsPrefab;
    [SerializeField] private float explosionRadius = 4f;
    private GameObject multipleBullet;
    private Rigidbody[] bullets;
    private void OnDestroy()
    {
        CreateNewBullets();
    }
    private void CreateNewBullets()
    {
        multipleBullet = Instantiate(multipleBulletsPrefab, transform.position, transform.rotation);
        bullets = multipleBullet.GetComponentsInChildren<Rigidbody>();
        AddForceToRigidbodies();
    }
    private void AddForceToRigidbodies()
    {
        foreach (Rigidbody bullet in bullets)
        {
            bullet.transform.rotation = Random.rotation;
            bullet.AddExplosionForce(Random.Range(500, 1000), transform.position, explosionRadius);
        }
    }
}
