using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaImg : MonoBehaviour
{
    public Image notaImg;

    // Start is called before the first frame update
    void Start()
    {
        notaImg = GameObject.Find("NotaImg").GetComponent<Image>();
        notaImg.sprite = Resources.Load<Sprite>("Sprites/NEUTRO");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            notaImg.sprite = Resources.Load<Sprite>("Sprites/DO");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            notaImg.sprite = Resources.Load<Sprite>("Sprites/FA");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            notaImg.sprite = Resources.Load<Sprite>("Sprites/LA");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            notaImg.sprite = Resources.Load<Sprite>("Sprites/MI");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            notaImg.sprite = Resources.Load<Sprite>("Sprites/RE");
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            notaImg.sprite = Resources.Load<Sprite>("Sprites/SI");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            notaImg.sprite = Resources.Load<Sprite>("Sprites/SOL");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            notaImg.sprite = Resources.Load<Sprite>("Sprites/DOREB");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            notaImg.sprite = Resources.Load<Sprite>("Sprites/FASOLB");
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            notaImg.sprite = Resources.Load<Sprite>("Sprites/LASIB");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            notaImg.sprite = Resources.Load<Sprite>("Sprites/REMIB");
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            notaImg.sprite = Resources.Load<Sprite>("Sprites/SOLLAB");
        }
    }
}
