using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaMi : MonoBehaviour
{
    public AudioSource notami;

    private Animator animmi;

    // Start is called before the first frame update
    void Start()
    {
        animmi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            notami.Play();
            animmi.SetBool("MIDOWN", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            animmi.SetBool("MIDOWN", false);
        }
    }
}
