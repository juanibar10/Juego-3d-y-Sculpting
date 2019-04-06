using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoCubo : MonoBehaviour
{
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
        }
    }
}
