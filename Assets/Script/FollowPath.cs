using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Transform trueTarget;
    [SerializeField] private Transform Spawnlocation;
    [SerializeField] private int childTarget = 0;
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalThreshold = 0.1f;

    private void Start()
    {
        transform.position = Spawnlocation.position;
        Debug.Log(_target);
    }

    private void Update()
    {
        trueTarget = _target.GetChild(childTarget);
        Vector3 heighOffsetPosition = new Vector3(trueTarget.position.x, transform.position.y, trueTarget.position.z);
        float distance = Vector3.Distance(a: transform.position, b: heighOffsetPosition);

        if (distance <= _arrivalThreshold)
        {
            print(message: "I have arrived");
            childTarget += 1;
        }
        else
        {
            transform.LookAt(heighOffsetPosition);
            transform.Translate(translation: Vector3.forward * _speed * Time.deltaTime);
        }
    }
}
