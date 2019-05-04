using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTimeSwap : MonoBehaviour
{
    public float timer = 2f;

    public int camera;

    GameObject cameraManager;

    // Start is called before the first frame update
    void Start()
    {
        cameraManager = GameObject.Find("CameraController");
        cameraManager.GetComponent<CameraManager>();
        StartCoroutine(Swap());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator Swap()
    {
        yield return new WaitForSeconds(timer);

        cameraManager.GetComponent<CameraManager>().SelectCamera(camera);

    }
}
