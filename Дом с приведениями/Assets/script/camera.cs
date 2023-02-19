using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Transform player;
    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("персонаж").transform;
    }
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x = player.position.x;
        temp.y = player.position.y;
        transform.position = temp;
       
    }
        
}
