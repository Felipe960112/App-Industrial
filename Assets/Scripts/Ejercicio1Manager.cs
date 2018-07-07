using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ejercicio1Manager : MonoBehaviour {

    public static Ejercicio1Manager Instance { set; get; }

    private int legos8 = 12;
    private int legos4 = 16;
    private int cantMesas = 0;
    private int cantSillas = 0;
    private int ganancias = 0;
    
    public Text Legos8;
    public Text Legos4;
    public Text CantMesas;
    public Text CantSillas;
    public Text Ganancias;

    private void Awake()   //private void Start, funciona antes del Start
    {
        Instance = this;

    }


    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update () {

        Legos8.text = legos8.ToString();
        Legos4.text = legos4.ToString();
        CantSillas.text = cantSillas.ToString();
        CantMesas.text = cantMesas.ToString();
        Ganancias.text = "$" + ganancias.ToString();


        //------Aqui debo verificar que hay cantidades disponibles, sumas y otros




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

    public void Silla()
    {
        if (legos8 >= 1 && legos4 >= 2)
        {
            cantSillas++;
            legos8 -= 1;
            legos4 -= 2;
            ganancias += 3000;
        }
    }


    public void Mesa()
    {
        if (legos8 >= 2 && legos4 >= 2)
        {
            cantMesas++;
            legos8 -= 2;
            legos4 -= 2;
            ganancias += 5000;
        }
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
