using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour {

    public static BarraVida Instance { set; get; }

    public Image barraDeVidaActual;
    public Text porcentajeText;

    private float hitpoint = 100;
    private float maxHitpoint = 100;
    private float minHitpoint = 0;

    //private Animator anim;

    private void Awake()   //private void Start, funciona antes del Start
    {
        Instance = this;

    }

    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    private void Update()
    {
        UpdateBarraVida();
    }

    private void UpdateBarraVida()
    {
        float porcentaje = hitpoint / maxHitpoint;
        barraDeVidaActual.rectTransform.localScale = new Vector3(porcentaje, 1, 1);
        porcentajeText.text = (porcentaje * 100).ToString("0") + '%';
    }

    private void TakeDamage(float damage) 
    {
        hitpoint -= damage;
        if (hitpoint < minHitpoint)
        {
            hitpoint = minHitpoint;
            UpdateBarraVida();
            //anim.SetTrigger("Death");
            Debug.Log("Moriste!");
            LevelManager.Instance.Muerte();
            
        }
    }

    private void HealDamage(float heal) 
    {
        hitpoint += heal;
        if (hitpoint > maxHitpoint)
        {
            hitpoint = maxHitpoint;
            UpdateBarraVida();
        }
    }

}
