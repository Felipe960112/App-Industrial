using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    // Use this for initialization
    private void Start()
    {

    }


    public void ToGame()
    {
        SceneManager.LoadScene("Nivel 1");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Instrucciones()
    {
        SceneManager.LoadScene("Instrucciones");
    }

    public void ToTips()
    {
        SceneManager.LoadScene("Tips");
    }

    // Update is called once per frame
    void Update () {

    }
}
