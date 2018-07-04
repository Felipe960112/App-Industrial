using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour {

    public static LevelManager Instance { set; get; }

    private int vidas = 3;
    private int monedas = 0;
    
    public Transform spawnPosition;
    public Transform playerTrasnform;

    public Text MonedasNivel;
    public Text VidasNivel;

    public GameObject winBox;
    public GameObject barraVida;
    
    private void Awake()   //private void Start, funciona antes del Start
    {
        Instance = this;

    }

    private void Update()
    {
        MonedasNivel.text = "Monedas adquiridas : " + monedas.ToString();
        VidasNivel.text = "Vidas restantes : " + vidas.ToString();

        if (vidas <= 0)
        {
            SceneManager.LoadScene("Menu");
        }

        winBox.SetActive(false);

        if (monedas == 3)
        {
            winBox.SetActive(true);
        }

        VidasNivel.text = "Vidas restantes : " + vidas.ToString();
    }



    public void Muerte()
    {
        playerTrasnform.position = spawnPosition.position;
        vidas--;
        VidasNivel.text = "Vidas restantes : " + vidas.ToString();
    }


    public void Win()
    {
        if (monedas > PlayerPrefs.GetInt("Monedas reunidas: "))
        {
            PlayerPrefs.SetInt("Monedas reunidas: ", monedas);
        }
        
        SceneManager.LoadScene("Menu");
    }

    public void CollectCoin()
    {
        monedas++;
        Debug.Log("Obtuviste una moneda!");
        MonedasNivel.text = "Monedas adquiridas : " + monedas.ToString();
    }

}
