using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour {

    public List<Vector3> waypoints = new List<Vector3>();

    public int next = 0;
    public bool looping = true;

    public void OnDrawGizmos()
    {
        int count = looping ? (transform.childCount + 1) : transform.childCount;
        Gizmos.color = Color.red;
        for(int i = 1; i < count; i++)
        {
            Transform last = transform.GetChild(i - 1);
            Transform next = transform.GetChild(i % transform.childCount);
            Gizmos.DrawLine(last.transform.position, next.transform.position);
            Gizmos.DrawSphere(last.position, 1);
            Gizmos.DrawSphere(next.position, 1);
        }
    }

    private void Start()
    {
        waypoints.Clear();
        int count = transform.childCount;
        for (int i = 0; i < count; i++)
        {
            waypoints.Add(transform.GetChild(i).position);
        }
    }

    public Vector3 NextWaypoint()
    {
        return waypoints[next];
    }

    public void GoToNext()
    {
        if(looping)
        {
            next = (next + 1) % waypoints.Count;
        }
        else
        {
            if(next != waypoints.Count -1)
            {
                next++;
            }
        }
    }

    public bool isLast()
    {
        return next == waypoints.Count - 1;
    }
 }
