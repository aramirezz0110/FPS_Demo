using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicBullet : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 4f);
    }
}
