using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaDo : MonoBehaviour
{
    public AudioSource notado;
    private Animator animdo;

    // Start is called before the first frame update
    void Start()
    {
        animdo = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            notado.Play();
            animdo.SetBool("DODOWN", true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            animdo.SetBool("DODOWN", false);
        }
    }
}
