using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(order =0, menuName = "Scriptable/ Simple Shoot Config", fileName ="New Simple Shoot Config")]
public class SimpleShootConfig : ScriptableObject
{
    [SerializeField] private string _bulletName;
    [SerializeField] private string _bulletDescription;
    [SerializeField] private GameObject _bullet;
    public GameObject bullet { get { return _bullet; } }
    public string bulletName { get { return _bulletName; } }
    public string bulletDescription { get { return _bulletDescription; } }
}
