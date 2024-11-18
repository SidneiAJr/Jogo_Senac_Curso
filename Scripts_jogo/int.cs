using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo_Inteligencia : MonoBehaviour
{
    public Transform[] waypoints;
    public float patrolSpeed = 2.0f;
    private int currentWaypoints = 0;
    // Update is called once per frame
    void Update()
    {
     Patrol();
    }
      void Patrol()
      {
       if(waypoints.Length == 0 ) return;
       Transform target = waypoints[currentWaypoints];
       Vector3 direction = (target.position - transform.position).normalized;
       transform.position += direction * patrolSpeed * Time.deltaTime;
       if(Vector3.Distance(transform.position,transform.position)<0.5f)
       {
       currentWaypoints = (currentWaypoints +1 ) % waypoints.Length;
       }
      }
    }
