using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beholder : Mover
{
    protected override void Move()
    {
        base.Move();

        transform.LookAt(Waypoints[CurrentWaypoint].position);
    }  
}
