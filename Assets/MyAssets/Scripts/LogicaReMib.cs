using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaReMib : MonoBehaviour
{
    public AudioSource notaremib;

    private Animator animremib;

    // Start is called before the first frame update
    void Start()
    {
        animremib = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            notaremib.Play();
            animremib.SetBool("REMIBDOWN", true);
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            animremib.SetBool("REMIBDOWN", false);
        }
    }
}
