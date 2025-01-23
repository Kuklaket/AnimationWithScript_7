using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] protected Transform[] Waypoints;
    [SerializeField] protected float Speed;

    protected int CurrentWaypoint = 0;

    protected virtual void Move()
    {
        if (transform.position == Waypoints[CurrentWaypoint].position)
            CurrentWaypoint = (CurrentWaypoint + 1) % Waypoints.Length;

        transform.position = Vector3.MoveTowards(transform.position, Waypoints[CurrentWaypoint].position, Speed * Time.deltaTime);
    }

    private void Update()
    {
        Move();
    }
}








