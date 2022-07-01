using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaSi : MonoBehaviour
{
    public AudioSource notasi;

    private Animator animsi;

    // Start is called before the first frame update
    void Start()
    {
        animsi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            notasi.Play();
            animsi.SetBool("SIDOWN", true);
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            animsi.SetBool("SIDOWN", false);
        }
    }
}
