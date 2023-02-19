using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class вещи : MonoBehaviour
{
    public GameObject pers;
    public GameObject[] gost;
    public Sprite sprite1;
    public Sprite sprite2;
    public LayerMask per;
    private SpriteRenderer sprl;
    public float distance;
    private bool n = false;
    void Start()
    {
        sprl = GetComponent<SpriteRenderer>();
        gost = GameObject.FindGameObjectsWithTag("призрак");
    }

    void Update()
    {
        RaycastHit2D personash = Physics2D.Raycast(transform.position, Vector2.up, distance, per);
        if (personash.collider != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (n == false)
                {
                    sprl.sprite = sprite1;
                    pers.GetComponent<SpriteRenderer>().enabled = false;
                    pers.GetComponent<NewBehaviourScript>().enabled = false;
                    for(int x = 0; x < gost.Length; x++)
                    {
                        gost[x].GetComponent<призракрандом>().ci = "t";
                    }
                    
                    n = true;
                }
                else
                {
                    sprl.sprite = sprite2;
                    pers.GetComponent<SpriteRenderer>().enabled = true;
                    pers.GetComponent<NewBehaviourScript>().enabled = true;
                    for (int x = 0; x < gost.Length; x++)
                    {
                        gost[x].GetComponent<призракрандом>().ci = "персонаж";
                    }

                    n = false;
                }
            }
        }
    }
}
