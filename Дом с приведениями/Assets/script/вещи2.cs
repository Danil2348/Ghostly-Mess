using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class вещи2 : MonoBehaviour
{
    public GameObject pers;
    public GameObject light;
    public LayerMask per;
    public float c;
    public float distance;
    private bool v = false;
    void Start()
    {

    }

    void Update()
    {
        RaycastHit2D personash = Physics2D.Raycast(transform.position, Vector2.up, distance, per);
        if (personash.collider != null)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (light.GetComponent<light>().on==true)
                {
                    if (pers.GetComponent<NewBehaviourScript>().crest == false)
                    {
                        c = Random.value;
                        if (c < pers.GetComponent<NewBehaviourScript>().it)
                        {
                            pers.GetComponent<NewBehaviourScript>().crest = true;
                        }
                        else
                        {
                            pers.GetComponent<NewBehaviourScript>().it += 1.0f / pers.GetComponent<NewBehaviourScript>().veshi;
                        }
                    }
                    GetComponent<вещи2>().enabled = false;
                }
               
            }
        }
    }
}
