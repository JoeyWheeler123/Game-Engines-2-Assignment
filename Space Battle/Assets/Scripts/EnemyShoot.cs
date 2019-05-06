using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject cannonBall;

    public GameObject[] targets;
    GameObject currentTarget;

    public int firePower = 1000;

    public float time = 3f;

    public int index;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireCannon());
        targets = GameObject.FindGameObjectsWithTag("Target");
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
    }

    IEnumerator FireCannon()
    {
        yield return new WaitForSeconds(time);
        index = Random.Range(0, targets.Length);
        currentTarget = targets[index];
        Fire();
    }
}
