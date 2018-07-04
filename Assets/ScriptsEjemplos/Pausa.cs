using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{

    public GameObject ObjPausa;

    // Use this for initialization
    void Start()                        //NO FUNCIONA CORRECTAMENTE EL SCRIPT
    {
        ObjPausa.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("P"))
        {
            if (Time.timeScale == 1)
            {    //si la velocidad es 1
                Time.timeScale = 0f;    //que la velocidad del juego sea 0
            }
            else if (Time.timeScale == 0)
            {   // si la velocidad es 0
                Time.timeScale = 1f;    // que la velocidad del juego regrese a 1
            }
        }
    }
}