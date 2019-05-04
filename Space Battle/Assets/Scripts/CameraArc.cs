using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArc : MonoBehaviour
{
    public float speed = 10f;

    public float height = 5f;

    public float distance = 10f;

    public Vector3 end;

    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime;

        //transform.position = ParabolaMovement.Parabola(pos, Vector3.forward * distance, height, speed / 5f);
        transform.position = ParabolaMovement.Parabola(pos, end, height, speed / 5f);
    }
}
