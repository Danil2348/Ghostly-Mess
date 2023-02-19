using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class страхометр : MonoBehaviour
{
    private int _strah1;
    private float y;
    private float x;
    public float[] z;
    public float b;
    public int a;
    private Df _animations;
    public GameObject pers;
    public GameObject[] gost;
    private Vector3 _input;
    private Vector3 _input2;
    public GameObject[] v;

    private void Start()
    {
        gost = GameObject.FindGameObjectsWithTag("призрак");
        z = new float[gost.Length];
        v = GameObject.FindGameObjectsWithTag("1");
        _animations = GetComponent<Df>();
    }

    private void FixedUpdate()
    {
        Move();

    }
    private void Move()
    {
        _input = pers.transform.position;
        for(int i = 0; i < gost.Length; i++)
        {
            _input2 = gost[i].transform.position;
            y = Mathf.Abs(Mathf.Abs(_input.y) - Mathf.Abs(_input2.y));
            x = Mathf.Abs(Mathf.Abs(_input.x) - Mathf.Abs(_input2.x));
            z[i] = x + y;
        }
        b = 1000;
        a = 0;
        for (int i = 0; i<z.Length; i++)
        {
            if (z[i] < b)
            {
                b = z[i];
                a = i;
            }
        }
        _input2 = gost[a].transform.position;
        y = Mathf.Abs(Mathf.Abs(_input.y) - Mathf.Abs(_input2.y));
        x = Mathf.Abs(Mathf.Abs(_input.x) - Mathf.Abs(_input2.x));
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i].GetComponent<light>().on == true)
            {
                if ((y <= 1.5) & (x <= 1))
                {
                    _strah1 = 4;
                    _animations.Strah1 = _strah1;
                }
                if ((y <= 1.5) & (x <= 3) & (x > 1))
                {
                    _strah1 = 3;
                    _animations.Strah1 = _strah1;
                }
                if ((y <= 1.5) & (x > 3))
                {
                    _strah1 = 2;
                    _animations.Strah1 = _strah1;
                }
                if ((y > 1.5) & (y <= 4))
                {
                    _strah1 = 1;
                    _animations.Strah1 = _strah1;
                }
                if (y > 4)
                {
                    _strah1 = 0;
                    _animations.Strah1 = _strah1;
                }
            }
            else
            {
                if ((y <= 1) || (x <= 1))
                {
                    _strah1 = 4;
                    _animations.Strah1 = _strah1;
                }
                if (((y <= 2.5) || (x <= 2.5)) & ((y > 1) || (x > 1)))
                {
                    _strah1 = 3;
                    _animations.Strah1 = _strah1;
                }
                if (((y <= 4.5) || (x <= 4.5)) & ((y > 2.5) || (x > 2.5)))
                {
                    _strah1 = 2;
                    _animations.Strah1 = _strah1;
                }
                if (((y <= 6.5) || (x <= 6.5)) & ((y > 4.5) || (x > 4.5)))
                {
                    _strah1 = 1;
                    _animations.Strah1 = _strah1;
                }
                if ((y > 6.5) || (x > 6.5))
                {
                    _strah1 = 0;
                    _animations.Strah1 = _strah1;
                }
            }
        }
    }
    public void str()
    {
        _strah1 = 0;
        _animations.Strah1 = _strah1;
    }
    //method to render from camera
    
}
