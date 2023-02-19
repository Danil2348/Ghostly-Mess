using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class прогирыш : MonoBehaviour
{
    public GameObject cnop;
    public GameObject text;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (text.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            cnop.SetActive(true);
        }
        else
        {
            cnop.SetActive(false);
        }
    }
    public void Retstart()
    {
        SceneManager.LoadScene("представление уровня");
        global.n = global.p;
    }
    public void menu()
    {
        SceneManager.LoadScene("меню");
    }
}
