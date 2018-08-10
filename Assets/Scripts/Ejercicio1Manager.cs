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

    public AudioClip sonidoCrear;
    public GameObject Mesa1;
    public GameObject Mesa2;
    public GameObject Mesa3;
    public GameObject Mesa4;
    public GameObject Mesa5;
    public GameObject Mesa6;
    public GameObject Silla1;
    public GameObject Silla2;
    public GameObject Silla3;
    public GameObject Silla4;
    public GameObject Silla5;
    public GameObject Silla6;
    public GameObject Silla7;
    public GameObject Silla8;



    AudioSource fuenteSonidoCrear;


    private void Awake()   //private void Start, funciona antes del Start
    {
        Instance = this;

    }


    // Use this for initialization
    void Start () {
        fuenteSonidoCrear = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {

        Legos8.text = legos8.ToString();
        Legos4.text = legos4.ToString();
        CantSillas.text = cantSillas.ToString();
        CantMesas.text = cantMesas.ToString();
        Ganancias.text = "$" + ganancias.ToString();


        Mesa1.SetActive(false);
        Mesa2.SetActive(false);
        Mesa3.SetActive(false);
        Mesa4.SetActive(false);
        Mesa5.SetActive(false);
        Mesa6.SetActive(false);

        Silla1.SetActive(false);
        Silla2.SetActive(false);
        Silla3.SetActive(false);
        Silla4.SetActive(false);
        Silla5.SetActive(false);
        Silla6.SetActive(false);
        Silla7.SetActive(false);
        Silla8.SetActive(false);


        if (cantMesas == 1)
        {
            Mesa1.SetActive(true);
            Mesa2.SetActive(false);
            Mesa3.SetActive(false);
            Mesa4.SetActive(false);
            Mesa5.SetActive(false);
            Mesa6.SetActive(false);
        }
        else if (cantMesas == 2)
        {
            Mesa1.SetActive(true);
            Mesa2.SetActive(true);
            Mesa3.SetActive(false);
            Mesa4.SetActive(false);
            Mesa5.SetActive(false);
            Mesa6.SetActive(false);
        }
        else if (cantMesas == 3)
        {
            Mesa1.SetActive(true);
            Mesa2.SetActive(true);
            Mesa3.SetActive(true);
            Mesa4.SetActive(false);
            Mesa5.SetActive(false);
            Mesa6.SetActive(false);
        }
        else if (cantMesas == 4)
        {
            Mesa1.SetActive(true);
            Mesa2.SetActive(true);
            Mesa3.SetActive(true);
            Mesa4.SetActive(true);
            Mesa5.SetActive(false);
            Mesa6.SetActive(false);
        }
        else if (cantMesas ==5)
        {
            Mesa1.SetActive(true);
            Mesa2.SetActive(true);
            Mesa3.SetActive(true);
            Mesa4.SetActive(true);
            Mesa5.SetActive(true);
            Mesa6.SetActive(false);
        }
        else if (cantMesas == 6)
        {
            Mesa1.SetActive(true);
            Mesa2.SetActive(true);
            Mesa3.SetActive(true);
            Mesa4.SetActive(true);
            Mesa5.SetActive(true);
            Mesa6.SetActive(true);
        }


        if (cantSillas == 1)
        {
            Silla1.SetActive(true);
            Silla2.SetActive(false);
            Silla3.SetActive(false);
            Silla4.SetActive(false);
            Silla5.SetActive(false);
            Silla6.SetActive(false);
            Silla7.SetActive(false);
            Silla8.SetActive(false);
        }
        else if (cantSillas == 2)
        {
            Silla1.SetActive(true);
            Silla2.SetActive(true);
            Silla3.SetActive(false);
            Silla4.SetActive(false);
            Silla5.SetActive(false);
            Silla6.SetActive(false);
            Silla7.SetActive(false);
            Silla8.SetActive(false);
        }
        else if (cantSillas == 3)
        {
            Silla1.SetActive(true);
            Silla2.SetActive(true);
            Silla3.SetActive(true);
            Silla4.SetActive(false);
            Silla5.SetActive(false);
            Silla6.SetActive(false);
            Silla7.SetActive(false);
            Silla8.SetActive(false);
        }
        else if (cantSillas == 4)
        {
            Silla1.SetActive(true);
            Silla2.SetActive(true);
            Silla3.SetActive(true);
            Silla4.SetActive(true);
            Silla5.SetActive(false);
            Silla6.SetActive(false);
            Silla7.SetActive(false);
            Silla8.SetActive(false);
        }
        else if (cantSillas == 5)
        {
            Silla1.SetActive(true);
            Silla2.SetActive(true);
            Silla3.SetActive(true);
            Silla4.SetActive(true);
            Silla5.SetActive(true);
            Silla6.SetActive(false);
            Silla7.SetActive(false);
            Silla8.SetActive(false);
        }
        else if (cantSillas == 6)
        {
            Silla1.SetActive(true);
            Silla2.SetActive(true);
            Silla3.SetActive(true);
            Silla4.SetActive(true);
            Silla5.SetActive(true);
            Silla6.SetActive(true);
            Silla7.SetActive(false);
            Silla8.SetActive(false);
        }
        else if (cantSillas == 7)
        {
            Silla1.SetActive(true);
            Silla2.SetActive(true);
            Silla3.SetActive(true);
            Silla4.SetActive(true);
            Silla5.SetActive(true);
            Silla6.SetActive(true);
            Silla7.SetActive(true);
            Silla8.SetActive(false);
        }
        else if (cantSillas == 8)
        {
            Silla1.SetActive(true);
            Silla2.SetActive(true);
            Silla3.SetActive(true);
            Silla4.SetActive(true);
            Silla5.SetActive(true);
            Silla6.SetActive(true);
            Silla7.SetActive(true);
            Silla8.SetActive(true);
        }


    }

    public void Silla()
    {
        if (legos8 >= 1 && legos4 >= 2)
        {
            cantSillas++;
            legos8 -= 1;
            legos4 -= 2;
            ganancias += 3000;
            fuenteSonidoCrear.clip = sonidoCrear;
            fuenteSonidoCrear.Play();
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
            fuenteSonidoCrear.clip = sonidoCrear;
            fuenteSonidoCrear.Play();
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
