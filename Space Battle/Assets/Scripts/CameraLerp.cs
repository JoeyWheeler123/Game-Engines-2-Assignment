using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerp : MonoBehaviour
{
    GameObject thisCamera;
    Vector3 pos;
    Vector3 targetPos;
    public GameObject otherCamera;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
       pos = transform.position;
       targetPos = otherCamera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //pos = Vector3.Lerp(cameraTransform.position, TargetPosition, 5.0f * Time.deltaTime);
        pos = Vector3.Lerp(transform.position, targetPos, time * Time.deltaTime); 
    }
}
