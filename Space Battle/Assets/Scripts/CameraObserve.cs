﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraObserve : MonoBehaviour
{
    public float speed = 100;

    public Transform ship;

    // Use this for initialization
    void Start()
    {
        //ship = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Vector3 toShip = ship.transform.position - transform.position;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(toShip), speed * Time.deltaTime);
    }
        

}
