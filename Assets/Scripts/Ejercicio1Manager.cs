using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ejercicio1Manager : MonoBehaviour {

    public static Ejercicio1Manager Instance { set; get; }

    //private int vidas = 3;
    //private int monedas = 0;
    
    public Text Legos6;
    public Text Legos4;

    private void Awake()   //private void Start, funciona antes del Start
    {
        Instance = this;

    }


    // Use this for initialization
    void Start () {
		
	}


    // Update is called once per frame
    void Update () {

        //MonedasNivel.text = "Monedas adquiridas : " + monedas.ToString();
        //VidasNivel.text = "Vidas restantes : " + vidas.ToString();

        //if (vidas <= 0)
        //{
        //    SceneManager.LoadScene("Menu");
        //}

        //winBox.SetActive(false);

        //if (monedas == 3)
        //{
        //    winBox.SetActive(true);
        //}

        //VidasNivel.text = "Vidas restantes : " + vidas.ToString();


    }


    //Sumar o restar valores
    //public void CollectCoin()
    //{
    //    monedas++;
    //    Debug.Log("Obtuviste una moneda!");
    //    MonedasNivel.text = "Monedas adquiridas : " + monedas.ToString();
    //}
    //public void Muerte()
    //{
    //    playerTrasnform.position = spawnPosition.position;
    //    vidas--;
    //    VidasNivel.text = "Vidas restantes : " + vidas.ToString();
    //}
}
