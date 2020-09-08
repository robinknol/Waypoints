using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWaypointSpawnlocation : MonoBehaviour
{
    void Start()
    {
        float x = Random.Range(-15f, 15f);
        float z = Random.Range(-5f, 5f);

        gameObject.transform.Translate(x,0,z);
    }
}
