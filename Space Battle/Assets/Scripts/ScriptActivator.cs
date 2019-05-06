using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptActivator : MonoBehaviour
{
    public GameObject c1;
    public GameObject c2;
      public GameObject c3;
        public GameObject c4;
        public GameObject c5;
        public GameObject c6;

    public GameObject fleet;

    // Start is called before the first frame update
    void Start()
    {
        c1.GetComponent<CannonShoot>().enabled = true;
        c2.GetComponent<CannonShoot>().enabled = true;
        c3.GetComponent<CannonShoot>().enabled = true;
        c4.GetComponent<CannonShoot>().enabled = true;
        c5.GetComponent<CannonShoot>().enabled = true;
        c6.GetComponent<CannonShoot>().enabled = true;

        fleet.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
