using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Opdrachten
{
    /// <summary>
    /// De path class beheerd een array van waypoints. En houd bij bij welk waypoint een object is.
    /// Deze vormen samen het pad. 
    /// Logica die op het path niveau plaatsvindt gebeurt in deze class.
    /// Een deel van de functies welke je nodig hebt zijn hier al beschreven.
    /// </summary>
    public class Path : MonoBehaviour
    {
        public GameObject[] Waypoint;
        public GameObject Spawnlocation;
        public int WaypointCounter = 0;
        public GameObject TrueTarget;
        /// <summary>
        /// Deze functie returned het volgende waypoint waar naartoe kan worden bewogen.
        /// </summary>
        public Waypoint GetNextWaypoint()
        {
            FindGameObjects();
            TrueTarget = Waypoint[WaypointCounter];
            return null;
        }

        public void FindGameObjects()
        {
            Waypoint = GameObject.FindGameObjectsWithTag("Waypoint");
            Spawnlocation = GameObject.FindGameObjectWithTag("Respawn");
        }
    }
}