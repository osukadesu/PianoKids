using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaDoReb : MonoBehaviour
{
    public AudioSource notadoreb;

    private Animator animdoreb;

    // Start is called before the first frame update
    void Start()
    {
        animdoreb = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            notadoreb.Play();
            animdoreb.SetBool("DOREBDOWN", true);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            animdoreb.SetBool("DOREBDOWN", false);
        }
    }
}
