using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void Ejercicio1()
    {
        SceneManager.LoadScene("Ejercicio1");
    }

    public void Actividades()
    {
        SceneManager.LoadScene("Inicio");
    }

    // Update is called once per frame
    void Update () {
		
	}

    //Codigo para instancear y ocultar objetos
    //este arriba:  public GameObject winBox;
    //winBox.SetActive(false);
}
