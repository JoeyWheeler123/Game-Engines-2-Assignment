using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanScroll : MonoBehaviour
{
    public bool scrolling;
    public float tiles;

    public Transform shipT;
    private Transform[] layers;
    private float tileSize = 300;
    private int backIndex;
    private int frontIndex;

    private float lastShipZ;

    private void Start()
    {
        lastShipZ = shipT.position.z;
        layers = new Transform[transform.childCount];
        for(int i = 0; i < transform.childCount; i ++)
        {
            layers[i] = transform.GetChild(i);
        }
        backIndex = 0;
        frontIndex = layers.Length - 1;
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.D))
        {
            ScrollForward();
        }*/

        if (shipT.position.z > (layers[backIndex].transform.position.z + tileSize))
        {
            ScrollForward();
        }
    }

    private void ScrollForward()
    {
        int lastBack = frontIndex;
        layers[backIndex].position = new Vector3(layers[frontIndex].position.x, 0, 1 * layers[frontIndex].position.z + tiles);
        frontIndex = backIndex;
        backIndex++;
        if(backIndex == layers.Length)
        {
            backIndex = 0;
        }
    }
}
