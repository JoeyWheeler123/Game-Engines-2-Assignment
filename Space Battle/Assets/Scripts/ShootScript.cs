using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    bool firing;

    public GameObject cannonBall;
    public GameObject ship;
    public GameObject firePos1;
    Rigidbody rb;

    public float time = 2f;

    public float fireRange;

    public int firePower = 1000;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireCannon());
        rb = cannonBall.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FireCannon()
    {
        while(true)
        {
            if(firing)
            {
                Instantiate(cannonBall, firePos1.transform.position, Quaternion.identity);
                rb.AddForce(transform.forward * firePower);
                Debug.Log("Shoot");
            }
            yield return new WaitForSeconds(time);
        }
    }

    private void OnCollisionEnter(Collider other)
    {
        firing = true;
    }


    /*public float DistanceToPlayer()
    {
        return Vector3.Distance(transform.position, player.transform.position);

    }*/

    /*public void Fire()
    {
        if (DistanceToPlayer() < fireRange)
        {
            shooting = true;
        }
        else
        {
            shooting = false;
        }

    }*/
}
