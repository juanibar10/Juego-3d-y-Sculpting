using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinaAscensor : MonoBehaviour
{
    public bool Estado = false;
    [HideInInspector]
    public Animator anim;

    public GameObject puertaArriba;
    public GameObject puertaAbajo;

    public GameObject boton1;
    public GameObject boton2;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }



    public void ActivarAnimacion(bool estado)
    {
        Estado = estado;
        if (estado)
        {
            anim.SetBool("Estado", estado);
        }
        else
        {
            anim.SetBool("Estado", estado);
        }
    }


    public void AbrirPuertaArriba()
    {
        puertaArriba.GetComponent<PuertaAscensor>().ActivarAnimacion(true);
    }
    public void AbrirPuertaAbajo()
    {
        puertaAbajo.GetComponent<PuertaAscensor>().ActivarAnimacion(true);
    }

    public void CerrarPuertaArriba()
    {
        puertaArriba.GetComponent<PuertaAscensor>().ActivarAnimacion(false);
    }
    public void CerrarPuertaAbajo()
    {
        puertaAbajo.GetComponent<PuertaAscensor>().ActivarAnimacion(false);
    }

    public void CambiandoFalse()
    {
        boton1.GetComponent<BotonAFalse>().cambiando = false;
        boton2.GetComponent<BotonAFalse>().cambiando = false;
    }

}
