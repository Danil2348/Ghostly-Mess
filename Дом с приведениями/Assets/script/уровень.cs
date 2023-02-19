using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class уровень : MonoBehaviour
{

    public Animator animator;
    void Start()

    {
        animator = GetComponent<Animator>();
        this.GetComponent<TextMeshProUGUI>().text = "Level " + global.n;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            SceneManager.LoadScene(global.n);
        }
    }
}
