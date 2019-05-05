using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public GameObject cannonBall;
    //public GameObject firePos1;

    public int firePower = 1000;

    public float time = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireCannon());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        GameObject clone;
        clone = Instantiate(cannonBall, transform.position, Quaternion.identity);
        clone.GetComponent<Rigidbody>().AddForce(transform.up * firePower, ForceMode.Impulse);
        Debug.Log("Shoot");
    }

    IEnumerator FireCannon()
    {
        yield return new WaitForSeconds(time);

        Fire();
    }
}
