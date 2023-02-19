using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class дверь : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    private SpriteRenderer sprl;
    public LayerMask personash1;
    public LayerMask gost1;
    public GameObject pers;
    public GameObject dver2;
    public GameObject go;
    public float distance;
    public bool j = false;
    public float x=0;
    void Start()
    {
        sprl = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        RaycastHit2D personash = Physics2D.Raycast(transform.position, Vector2.up, distance, personash1);
        if (personash.collider != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                sprl.sprite = sprite2;
                dver2.GetComponent<SpriteRenderer>().sprite = sprite2;
                StartCoroutine(waiter3(0.7f));
                StartCoroutine(waiter2(0.1f));
                StartCoroutine(waiter(0.3f));
            }
        }
        RaycastHit2D gost = Physics2D.Raycast(transform.position, Vector2.up, distance, gost1);
        if (gost.collider != null)
        {
            if (x == 0)
            {
                x = Random.value;
                if (x > 0.5f)
                {
                    dver2.GetComponent<дверь>().x = -1;
                    go = gost.collider.gameObject;
                    sprl.sprite = sprite2;
                    dver2.GetComponent<SpriteRenderer>().sprite = sprite2;
                    StartCoroutine(waiter3(0.7f));
                    StartCoroutine(waiter4(0.1f));
                    StartCoroutine(waiter(0.3f));
                }
            }

        }
        
    }
    IEnumerator waiter(float time)
    {
        yield return new WaitForSeconds(time);
        sprl.sprite = sprite1;
    }
    IEnumerator waiter3(float time)
    {
        yield return new WaitForSeconds(time);
        dver2.GetComponent<SpriteRenderer>().sprite = sprite1;
    }
    IEnumerator waiter2(float time)
    {
        yield return new WaitForSeconds(time);
        pers.transform.position = new Vector3(dver2.transform.position.x, dver2.transform.position.y-0.1f, pers.transform.position.z);
    }
    IEnumerator waiter4(float time)
    {
        yield return new WaitForSeconds(time);
        go.transform.position = new Vector3(dver2.transform.position.x, dver2.transform.position.y - 0.1f, go.transform.position.z);
        go.GetComponent<призракрандом>().t = 1;
        x = 0f;
        StartCoroutine(waiter5(5f));

    }
    IEnumerator waiter5(float time)
    {
        yield return new WaitForSeconds(time);
        dver2.GetComponent<дверь>().x = 0;

    }
}

