using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobBehaviour : MonoBehaviour
{
    float frequency = 5f;

    float magnitude = 0.3f;

    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
       transform.localPosition = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
    }
}
