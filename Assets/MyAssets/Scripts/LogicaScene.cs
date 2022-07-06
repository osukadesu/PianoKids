using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaScene : MonoBehaviour
{
    public void PrincipalScene()
    {
        SceneManager.LoadScene(0);
    }

     public void StarScene()
    {
        SceneManager.LoadScene(1);
    }
}
