using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public GameObject[] s;
    public GameObject[] t;
    public bool on;
    public Sprite sprite1;
    public Sprite sprite2;
    private SpriteRenderer sprl;
    private SpriteRenderer tl;
    private SpriteRenderer tl1;
    private SpriteRenderer tl2;
    public Sprite sprite3;
    public Sprite sprite4;
    void Start()
    {
        s = GameObject.FindGameObjectsWithTag("свет");
        t = GameObject.FindGameObjectsWithTag("светильник");
        sprl=GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        if (on == false)
        {
            for (int x = 0; x < s.Length; x++)
            {
                s[x].SetActive(false);
            }
            for (int x = 0; x < t.Length; x++)
            {
                t[x].GetComponent<SpriteRenderer>().sprite = sprite2;
            }
            sprl.sprite = sprite3;
        }
        else
        {
            for (int x = 0; x < s.Length; x++)
            {
                s[x].SetActive(true);
            }
            for (int x = 0; x < t.Length; x++)
            {
                t[x].GetComponent<SpriteRenderer>().sprite = sprite1;
            }
            sprl.sprite = sprite4;
        }
    }
}
