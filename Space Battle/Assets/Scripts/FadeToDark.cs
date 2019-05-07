using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToDark : MonoBehaviour
{
    public GameObject fadeManager;
    public float t = 6f;

    // Start is called before the first frame update
    void Start()
    {
        fadeManager.GetComponent<FadeManager>().Fade(true, t);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
