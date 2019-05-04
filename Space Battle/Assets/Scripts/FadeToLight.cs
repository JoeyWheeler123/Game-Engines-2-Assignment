using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToLight : MonoBehaviour
{
    public GameObject fadeManager;
    public float t = 3f;

    // Start is called before the first frame update
    void Start()
    {
        fadeManager.GetComponent<FadeManager>().Fade(false, t);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
