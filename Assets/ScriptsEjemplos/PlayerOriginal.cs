using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOriginal : MonoBehaviour {

    public float gravity = 20.0f;
    private Vector3 moveVector;   //Crea los componenetes para vector en 3 dimensiones
    private CharacterController controller;   //Crea un controlador para manejar el personaje
    public float runSpeed = 20f;
    public float walkSpeed = 5f;
    //private Animator anim;
    public AudioClip sonidoMoneda;
    public AudioClip sonidoCurar;
    public AudioClip sonidoEnemigo;
    AudioSource fuenteSonidoMoneda;
    AudioSource fuenteSonidoCurar;
    AudioSource fuenteSonidoEnemigo;

    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();   //Crea la conexión entre el controlador de este script y el del objeto
        fuenteSonidoMoneda = GetComponent<AudioSource>();
        fuenteSonidoCurar = GetComponent<AudioSource>();
        fuenteSonidoEnemigo = GetComponent<AudioSource>();
        //anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        moveVector = Vector3.zero;
        if (controller.isGrounded)
        {
            moveVector = new Vector3(0, 0, Input.GetAxis("Vertical")); //Movimiento
            moveVector = transform.TransformDirection(moveVector);
            moveVector *= walkSpeed;
            transform.Rotate(0, Input.GetAxis("Horizontal") * 2, 0); //Rotacion
        }
        //if (controller.velocity != Vector3.zero)
        //    transform.forward = controller.velocity;

        //Vector3 moveDelta = new Vector3(x, -1, z);
        moveVector.y -= gravity;
        controller.Move(moveVector);
    }

    private void OnTriggerEnter(Collider col)
    {

            //Coleccionables
            switch (col.tag)
            {
                case "Coin":
                    fuenteSonidoMoneda.clip = sonidoMoneda;
                    fuenteSonidoMoneda.Play();
                    Destroy(col.gameObject);
                    LevelManager.Instance.CollectCoin();
                    break;

            case "Curar":
                fuenteSonidoCurar.clip = sonidoCurar;
                fuenteSonidoCurar.Play();
                break;

            case "Enemy1":
                fuenteSonidoEnemigo.clip = sonidoEnemigo;
                fuenteSonidoEnemigo.Play();
                break;

            case "Muerte":
                    LevelManager.Instance.Muerte();
                    break;

                case "Victoria":
                    LevelManager.Instance.Win();
                    break;

                default:
                    break;
            }

        
    }


}
