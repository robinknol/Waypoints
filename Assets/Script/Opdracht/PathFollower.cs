using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Opdrachten
{
    /// <summary>
    /// De path follower class is verantwoordelijk voor de beweging.
    /// Deze class zorgt ervoor dat het object (in Tower Defense) vaak een enemy, het path afloopt
    /// tip: je kunt de transform.LookAt() functie gebruiken en vooruitbewegen.
    /// </summary>
    public class PathFollower : Path
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _arrivalThreshold = 0.1f;

        private void Start()
        {
            GetNextWaypoint();
            transform.position = Spawnlocation.transform.position;
        }

        private void Update()
        {
            Vector3 direction = new Vector3(TrueTarget.transform.position.x, transform.position.y, TrueTarget.transform.position.z);
            float distance = Vector3.Distance(a: transform.position, b: direction);

            if (distance <= _arrivalThreshold)
            {
                print(message: "I have arrived");
                WaypointCounter += 1;
            }
            else
            {
                transform.LookAt(direction);
                transform.Translate(translation: Vector3.forward * _speed * Time.deltaTime);
            }
        }
    }
}