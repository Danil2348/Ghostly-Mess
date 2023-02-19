using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class местокрест : MonoBehaviour
{

    public LayerMask pers;
    public GameObject pers1;
    public GameObject[] gost;
    public float distance;
    public GameObject crest1;
    public GameObject crest2;
    public GameObject str;
    public GameObject exit1;
    public GameObject exit2;
    void Start()
    {
        gost = GameObject.FindGameObjectsWithTag("призрак");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D per = Physics2D.Raycast(transform.position, Vector2.up, distance, pers);
        if (per.collider != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (pers1.GetComponent<NewBehaviourScript>().crest == true)
                {
                    crest1.GetComponent<SpriteRenderer>().enabled = true;
                    crest1.GetComponent<Light>().enabled = true;
                    crest2.GetComponent<SpriteRenderer>().enabled = false;
                    pers1.GetComponent<NewBehaviourScript>().crest = false;
                    for(int x = 0; x < gost.Length; x++)
                    {
                        Destroy(gost[x]);
                    }
                    
                    str.GetComponent<страхометр>().str();
                    str.GetComponent<страхометр>().enabled = false;
                    exit1.GetComponent<BoxCollider2D>().isTrigger = true;
                    exit2.GetComponent<SpriteRenderer>().enabled=true;
                }
            }
        }
    }
}
