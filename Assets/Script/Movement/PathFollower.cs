using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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
        private GameObject Player;
        private PlayerHealth PlayerHealth;
        
        private UnityEvent m_MyEvent;

        private void Start()
        {
            

            if (m_MyEvent == null)
            {
                m_MyEvent = new UnityEvent();
            }

            m_MyEvent.AddListener(Ping);
            Spawnlocation = GameObject.FindGameObjectWithTag("Respawn");
            transform.position = Spawnlocation.transform.position;
        }

        void Ping()
        {
            Player = GameObject.FindGameObjectWithTag("Player");
            PlayerHealth = Player.GetComponent<PlayerHealth>();

            PlayerHealth.TakeDamage();
            Debug.Log("Ping");
        }

        private void Update()
        {
            GetNextWaypoint();

            Vector3 direction = new Vector3(TrueTarget.transform.position.x, transform.position.y, TrueTarget.transform.position.z);
            float distance = Vector3.Distance(transform.position, direction);

            if (distance <= _arrivalThreshold)
            {
                if (WaypointCounter == Waypoint.Length-1)
                {
                    m_MyEvent.Invoke();
                }
                else
                {
                    WaypointCounter++;
                }
            }
            else
            {
                transform.LookAt(direction);
                transform.Translate(Vector3.forward * _speed * Time.deltaTime);
            }
        }
        
        
    }
}