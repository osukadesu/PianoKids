using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaFaSolb : MonoBehaviour
{
    public AudioSource notafasolb;

    private Animator animfasolb;

    // Start is called before the first frame update
    void Start()
    {
        animfasolb = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            notafasolb.Play();
            animfasolb.SetBool("FASOLBDOWN", true);
        }
        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            animfasolb.SetBool("FASOLBDOWN", false);
        }
    }
}
