using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class выйгрыш : MonoBehaviour
{
    public LayerMask pers;
    public float distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, distance, pers);
        if (hit.collider != null)
        {

            SceneManager.LoadScene("представление уровня");
            global.n = global.n + 1;
        }
    }
}
