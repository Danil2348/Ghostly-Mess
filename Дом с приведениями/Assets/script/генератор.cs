using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class генератор : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    private SpriteRenderer sprl;
    public bool onf=false;
    public GameObject[] c;
    void Start()
    {
        c = GameObject.FindGameObjectsWithTag("1");
        sprl = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (onf == true)
        {
            sprl.sprite = sprite2;
        }
        else
        {
            sprl.sprite = sprite1;
            for(int x = 0; x < c.Length; x++)
            {
                c[x].GetComponent<light>().on = false;
            }
            
        }
    }
}
