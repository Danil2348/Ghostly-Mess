using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Collider;
using UnityEngine.SceneManagement;

public class призракрандом : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _input;
    public GameObject[] l;
    public SpriteRenderer a;
    public string ci = "персонаж";
    [SerializeField] private SpriteRenderer _characterSprite;

    public GameObject[] c;
    public float ti;
    public Vector3 p0;
    public Vector3 p1;
    public Vector3 p2;
    public Vector3 p3;
    public float speed = 0.2f;
    [Range(0, 1)]
    public float t;
   
    void Start()
    {
        
        l = GameObject.FindGameObjectsWithTag("1");
        pur();
    }
    void Update()
    {
        if (t >= 1)
        {
            pur();
            t = 0;
        }
        if (l[0].GetComponent<light>().on == false)
        {
            ti = 0;   
            a.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            if (ti == 0)
            {
                pur();
                ti = 1;
            }
            a.GetComponent<SpriteRenderer>().enabled = false;
        }
        transform.position = Bezie.GetPoint(p0, p1, p2, p3, t);
        transform.rotation = Quaternion.LookRotation(new Vector3(0f, 0f, -(Bezie.GetRotate(p0, p1, p2, p3, t)).x));
        t += speed * Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D Col)
    {
        if (Col.gameObject.tag == ci)
        {
            SceneManager.LoadScene("представление уровня");
            global.p = global.n;
            global.n = -1;
        }
    }
    
    public void pur()
    {
        p0 = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        if (l[0].GetComponent<light>().on == false)
        {
            
            p1 = new Vector3(Random.Range(c[0].transform.position.x, c[c.Length-1].transform.position.x), Random.Range(c[0].transform.position.y, c[c.Length-1].transform.position.y), transform.position.z);
            p2 = new Vector3(Random.Range(c[0].transform.position.x, c[c.Length-1].transform.position.x), Random.Range(c[0].transform.position.y, c[c.Length-1].transform.position.y), transform.position.z);
            p3 = new Vector3(Random.Range(c[0].transform.position.x, c[c.Length-1].transform.position.x), Random.Range(c[0].transform.position.y, c[c.Length-1].transform.position.y), transform.position.z);
        }
        else
        {
            for(int i = 0; i < c.Length; i++)
            {
                
                if((transform.position.x >= c[i].transform.position.x && transform.position.x <= c[i+1].transform.position.x) &&(transform.position.y<= c[i].transform.position.y && transform.position.y>= c[i + 1].transform.position.y))
                {
                    p1 = new Vector3(Random.Range(c[i].transform.position.x, c[i+1].transform.position.x), Random.Range(c[i].transform.position.y, c[i+1].transform.position.y), transform.position.z);
                    p2 = new Vector3(Random.Range(c[i].transform.position.x, c[i+1].transform.position.x), Random.Range(c[i].transform.position.y, c[i+1].transform.position.y), transform.position.z);
                    p3 = new Vector3(Random.Range(c[i].transform.position.x, c[i+1].transform.position.x), Random.Range(c[i].transform.position.y, c[i+1].transform.position.y), transform.position.z);
                }
            }
            
        }
    }
    private void OnDrawGizmos()
    {
        int sig = 20;
        Vector3 prev = p0;
        for (int i = 1; i < sig + 1; i++)
        {
            float par = (float)i / sig;
            Vector2 point = Bezie.GetPoint(p0, p1, p2, p3, par);
            Gizmos.DrawLine(prev, point);
            prev = point;
        }
    }
}
