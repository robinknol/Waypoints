using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWaypointSpawnlocation : MonoBehaviour
{
    public float x;
    void Start()
    {
        x = Random.Range(-10f, 10f);

        gameObject.transform.Translate(x,0,x);
    }
}
