using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public GameObject Waypoint;
    private int maxTime = 250;
    public int timer;
    void Start()
    {
        timer = maxTime;
        gameObject.transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        timer -= 1;
        if(timer == 0)
        {
            Vector3 location = Waypoint.transform.position;
            location.x = location.x += 1;
            location.z = location.z += 1;
            Debug.Log(location);
            gameObject.transform.Translate(location);
            timer = maxTime;
        }
    }
}
