using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    public float speed;
    private Vector3 _input;
    private bool _isMoving;
    public GameObject[] v;
    public float it = 0.1f;
    public int veshi;
    public bool crest = false;
    public GameObject generator;
    public GameObject krest;

    private bool x = false;

    public Rigidbody2D _rigidbody;
    private Dfhh _animations;
    [SerializeField] private SpriteRenderer _characterSprite;

    public float distance;
    public LayerMask whatisLabber;
    public LayerMask whatisLabber1;
    public LayerMask whatisLabber2;
    private bool Climbing;
    private void Start()
    {
        v = GameObject.FindGameObjectsWithTag("1");
        _rigidbody.GetComponent<Rigidbody2D>();
        _animations = GetComponent<Dfhh>();
        it +=(1.0f / veshi )-0.1f;
    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        
        _input = new Vector2(Input.GetAxis("Horizontal"), 0);
        transform.position += _input * _speed * Time.deltaTime;
        _isMoving = _input.x != 0 ? true : false;
        if (_isMoving)
        {
            _characterSprite.flipX = _input.x > 0 ? false : true;
        }
        _animations.IsMoving = _isMoving;
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatisLabber);
        if (hitinfo.collider != null)
        {
            _rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") * speed);
            _rigidbody.gravityScale = 0;
        }
        else
        {
            _rigidbody.gravityScale = 1;
        }
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, distance, whatisLabber1);
        if (hit.collider != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (generator.GetComponent<генератор>().onf == true)
                {
                    for (int x = 0; x < v.Length; x++)
                    {
                        if (v[x].GetComponent<light>().on == false)
                        {
                            v[x].GetComponent<light>().on = true;
                        }
                        else
                        {
                            v[x].GetComponent<light>().on = false;
                        }
                    }
                }
            }
        }
        RaycastHit2D hite = Physics2D.Raycast(transform.position, Vector2.up, distance, whatisLabber2);
        if (hite.collider != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (generator.GetComponent<генератор>().onf == false)
                {
                    generator.GetComponent<генератор>().onf = true;
                }
                else
                {
                    generator.GetComponent<генератор>().onf = false;
                }
            }
        }
        if (crest == true)
        {
            krest.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
    
}
