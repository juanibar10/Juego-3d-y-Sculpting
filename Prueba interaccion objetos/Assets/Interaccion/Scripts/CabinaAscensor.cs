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
    public GameObject boton3;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }



    public void ActivarAnimacion(bool estado)
    {
        anim.SetBool("Estado", estado);
        Estado = estado;
    }


    public void AbrirPuertaArriba()
    {
        puertaArriba.GetComponent<PuertaAscensor>().ActivarAnimacion(true);
        boton1.GetComponent<BotonAFalse>().corrigiendoUbicacion = false;
    }
    public void AbrirPuertaAbajo()
    {
        puertaAbajo.GetComponent<PuertaAscensor>().ActivarAnimacion(true);
        boton2.GetComponent<BotonAFalse>().corrigiendoUbicacion = false;
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
        boton3.GetComponent<BotonAFalse>().cambiando = false;
    }

}
