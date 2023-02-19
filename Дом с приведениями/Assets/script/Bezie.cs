using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Bezie 
{
    public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
    {
        t = Mathf.Clamp01(t);
        float oneMinust = 1f - t;
        return oneMinust * oneMinust * oneMinust * p0 + 3f * oneMinust * oneMinust * t * p1 + 3f * oneMinust * t * t * p2 + t * t * t * p3;
    }
    public static Vector3 GetRotate(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
    {
        t = Mathf.Clamp01(t);
        float oneMinust = 1f - t;
        return 3f*oneMinust * oneMinust  * (p1-p0) + 6f  * oneMinust * t * (p2-p1) + 3f * t * t * (p3-p2);
    }
}
