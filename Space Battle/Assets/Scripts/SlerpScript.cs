using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlerpScript : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;
    public float journeyTime = 1.0f;
    public float speed;
    public bool repeatable;

    public Vector3 dir;

    float startTime;
    Vector3 centerPoint;
    Vector3 startRelCenter;
    Vector3 endRelCenter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCenter(dir);
            {
            if (!repeatable)
            {
                float fracComplete = (Time.time - startTime) / journeyTime * speed;
                transform.position = Vector3.Slerp(startRelCenter, endRelCenter, fracComplete * speed);
                transform.position += centerPoint;
            }
            else
            {
                float fracComplete = Mathf.PingPong(Time.time - startTime, journeyTime / speed);
                transform.position = Vector3.Slerp(startRelCenter, endRelCenter, fracComplete * speed);
                transform.position += centerPoint;
            }
        }
    }

    public void GetCenter(Vector3 direction)
    {
        centerPoint = (startPos.position + endPos.position) * .5f;
        centerPoint -= direction;
        startRelCenter = startPos.position - centerPoint;
        endRelCenter = endPos.position - centerPoint;
    }
}
