using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaFa : MonoBehaviour
{
    public AudioSource notafa;

    private Animator animfa;

    // Start is called before the first frame update
    void Start()
    {
        animfa = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            notafa.Play();
            animfa.SetBool("FADOWN", true);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            animfa.SetBool("FADOWN", false);
        }
    }
}
