using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaRe : MonoBehaviour
{
    public AudioSource notare;
    private Animator animre;

    // Start is called before the first frame update
    void Start()
    {
        animre = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            notare.Play();
            animre.SetBool("REDOWN", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animre.SetBool("REDOWN", false);
        }
    }
}
