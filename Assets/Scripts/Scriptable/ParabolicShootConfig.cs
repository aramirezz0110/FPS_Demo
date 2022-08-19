using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(order =0, menuName ="Scriptable/ Parabolic Shoot Config", fileName ="New Parabolic Shoot Config"),]
public class ParabolicShootConfig : ScriptableObject
{
    [SerializeField] private string _bulletName;
    [SerializeField] private string _bulletDescription;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _bulletImpulse;
    public GameObject bullet { get { return _bullet; } }
    public float bulletImpulse { get { return _bulletImpulse; } }
    public string bulletName { get { return _bulletName; } }
    public string bulletDescription { get { return _bulletDescription; } }
}
