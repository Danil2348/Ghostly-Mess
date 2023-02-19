using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class лестница : MonoBehaviour
{
    private float inputVertical;
    public float speed;
    Rigidbody2D rb;
    public float distance;
    public LayerMask whatisLabber;
    private bool Climbing;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatisLabber);
        if (hitinfo.collider != null)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Climbing = true;
            }
        }
        else
        {
            Climbing = false;
        }
        if(Climbing == true && hitinfo.collider != null)
        {
            inputVertical = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(Input.GetAxis("Horizontal"), inputVertical * speed);
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = 1;
        }
    }
}
