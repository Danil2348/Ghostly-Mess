using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Df : MonoBehaviour
{
    private Animator _animator;
    public int Strah1 { private get; set; }
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (Strah1 == 1)
        {
            _animator.SetBool("strah1", true);
            _animator.SetBool("strah2", false);
            _animator.SetBool("strah3", false);
            _animator.SetBool("strah4", false);
        }
        if (Strah1 == 2)
        {
            _animator.SetBool("strah2", true);
            _animator.SetBool("strah1", false);
            _animator.SetBool("strah3", false);
            _animator.SetBool("strah4", false);
        }
        if (Strah1 == 3)
        {
            _animator.SetBool("strah3", true);
            _animator.SetBool("strah1", false);
            _animator.SetBool("strah2", false);
            _animator.SetBool("strah4", false);
        }
        if (Strah1 == 4)

        {
            _animator.SetBool("strah4", true);
            _animator.SetBool("strah1", false);
            _animator.SetBool("strah2", false);
            _animator.SetBool("strah3", false);
        }
        if (Strah1 == 0)
        {
            _animator.SetBool("strah1", false);
            _animator.SetBool("strah2", false);
            _animator.SetBool("strah3", false);
            _animator.SetBool("strah4", false);
        }
    }
}
