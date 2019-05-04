using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera[] cameras;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            SelectCamera(1);
        }
    }

    public void SelectCamera(int index)
    {
        ResetCameras();
        cameras[index].gameObject.SetActive(true);
    }

    void ResetCameras()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            if (cameras[i].gameObject.activeSelf)
            {
                cameras[i].gameObject.SetActive(false);
            }
        }
    }
}
