using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yfx : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    void Start()
    {
        if (global.n == -1)
        {
            one.SetActive(false);
            three.SetActive(false);
            two.SetActive(true);
        }
        else if (global.n == 6)
        {
            one.SetActive(false);
            three.SetActive(true);
            two.SetActive(false);
        }
        else
        {
            one.SetActive(true);
            three.SetActive(false);
            two.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
