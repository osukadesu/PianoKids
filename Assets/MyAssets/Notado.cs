using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notado : MonoBehaviour
{
    public Animator animdo;
    void Start()
    {
        animdo.SetBool("doneutro", true);
        animdo.SetBool("dodown", false);
    }
    // Update is called once per frame
    void Update()
    {
        teclado();
    }
    private void teclado()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animdo.SetBool("dodown", true);
        }
        animdo.SetBool("dodown", false);
    }
}