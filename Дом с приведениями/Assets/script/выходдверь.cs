using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class выходдверь : MonoBehaviour
{
    public GameObject dver2;
    public LayerMask pers;
    public float distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "персонаж")
        {
            this.GetComponent<BoxCollider2D>().isTrigger = true;
            this.GetComponent<SpriteRenderer>().enabled = false;
            dver2.GetComponent<SpriteRenderer>().enabled = true;
            StartCoroutine(waiter(1f));
            
        }
    }
    IEnumerator waiter(float time)
    {
        yield return new WaitForSeconds(time);
        this.GetComponent<BoxCollider2D>().isTrigger = false;
        this.GetComponent<SpriteRenderer>().enabled = true;
        dver2.GetComponent<SpriteRenderer>().enabled = false;
    }
}
