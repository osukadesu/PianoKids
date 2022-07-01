using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaSol : MonoBehaviour
{
    public AudioSource notasol;
    private Animator animsol;

    // Start is called before the first frame update
    void Start()
    {
        animsol = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            notasol.Play();
            animsol.SetBool("SOLDOWN", true);
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            animsol.SetBool("SOLDOWN", false);
        }
    }
}
