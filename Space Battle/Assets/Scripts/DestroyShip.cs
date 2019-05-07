using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShip : MonoBehaviour
{
    //public Animation anim;

    // public AnimationClip clip;

    //GameObject ship;

    // Start is called before the first frame update
    void Start()
    {
        //ship = GameObject.FindWithTag("Die");
        //estroy(ship);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
    }

}
