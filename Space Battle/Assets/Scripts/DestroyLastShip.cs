using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLastShip : MonoBehaviour
{
    GameObject ship;

    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.FindWithTag("Die");
        Destroy(ship);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
