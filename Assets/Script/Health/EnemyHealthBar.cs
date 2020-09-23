using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    private Quaternion rotate;
    void Awake()
    {
        rotate = transform.rotation;
    }

    void Update()
    {
        transform.rotation = rotate;
    }
}


