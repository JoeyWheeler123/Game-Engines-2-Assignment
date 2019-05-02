using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArc : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime;

        transform.position = ParabolaMovement.Parabola(Vector3.zero, Vector3.forward * 10f, 5f, speed / 5f);
    }
}
