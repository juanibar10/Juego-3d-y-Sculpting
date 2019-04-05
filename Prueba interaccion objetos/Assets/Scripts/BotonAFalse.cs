using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonAFalse : MonoBehaviour
{
    public Animator anim;
    public GameObject puerta;
    public bool pulsado = false;
    
    public void Update()
    {
        anim.SetBool("BotonPulsado", pulsado);

        if (pulsado)
        {
            puerta.GetComponent<Animator>().SetBool("Estado", true);
        }
    }

    /*
    public bool abierto = false;
    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }



    public void ActivarAnimacion(bool estado)
    {
        if (estado)
        {
            anim.SetBool("Estado", estado);
        }
        else
        {
            anim.SetBool("Estado", estado);
            anim.Play("Cubo_vuelve");
            anim.Play("IdleCubo");
        }
    }*/
}
