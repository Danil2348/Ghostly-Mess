using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bazietest : MonoBehaviour
{
    public GameObject[] c;
    public Vector3 p0;
    public Vector3 p1;
    public Vector3 p2;
    public Vector3 p3;
    public float speed = 0.001f;
    [Range(0, 1)]
    public float t;
    public void pur()
    {
        p0 = new Vector3(transform.position.x,transform.position.y,transform.position.z);
        p1 = new Vector3(Random.Range(c[0].transform.position.x, c[1].transform.position.x), Random.Range(c[0].transform.position.y, c[1].transform.position.y), transform.position.z);
        p2 = new Vector3(Random.Range(c[0].transform.position.x, c[1].transform.position.x), Random.Range(c[0].transform.position.y, c[1].transform.position.y), transform.position.z);
        p3 = new Vector3(Random.Range(c[0].transform.position.x, c[1].transform.position.x), Random.Range(c[0].transform.position.y, c[1].transform.position.y), transform.position.z);
    }
    public void Start()
    {
        c= GameObject.FindGameObjectsWithTag("point1");
        pur();
    }

    public void Update()
    {
        if (t >= 1)
        {
            pur();
            t = 0;
        }
        transform.position = Bezie.GetPoint(p0,p1,p2,p3,t);
        transform.rotation = Quaternion.LookRotation(new Vector3(0f,0f,-(Bezie.GetRotate(p0, p1, p2, p3, t)).x));
        t+=speed*Time.deltaTime;
    }

    private void OnDrawGizmos()
    {
        int sig = 20;
        Vector3 prev = p0;
        for(int i = 1; i < sig + 1; i++)
        {
            float par = (float)i / sig;
            Vector2 point = Bezie.GetPoint(p0, p1, p2, p3, par);
            Gizmos.DrawLine(prev, point);
            prev=point;
        }
    }

}





