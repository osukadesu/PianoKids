using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaSolLab : MonoBehaviour
{
    public AudioSource notasollab;

    private Animator animsollab;

    // Start is called before the first frame update
    void Start()
    {
        animsollab = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            notasollab.Play();
            animsollab.SetBool("SOLLABDOWN", true);
        }
        if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            animsollab.SetBool("SOLLABDOWN", false);
        }
    }
}