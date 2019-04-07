using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonAFalse : MonoBehaviour
{
    public Animator anim;
    public GameObject puerta;
    public GameObject cabina;
    public bool pulsado = false;
    public bool ubicacion;
    public bool diferente;
    public bool cambiando;
    [HideInInspector]
    public bool corrigiendoUbicacion;

    public void Update()
    {
        if (!puerta.GetComponent<PuertaAscensor>().abierto && gameObject.tag == "Boton")
            cambiando = false;
        
        if (!pulsado)
            anim.SetBool("BotonPulsado", pulsado);

        

        if (ubicacion && cabina.GetComponent<CabinaAscensor>().Estado  && !cambiando)
            diferente = false;
        else if (ubicacion && !cabina.GetComponent<CabinaAscensor>().Estado && !cambiando)
            diferente = true;

        if (!ubicacion && cabina.GetComponent<CabinaAscensor>().Estado && !cambiando)
            diferente = true;
        else if (!ubicacion && !cabina.GetComponent<CabinaAscensor>().Estado && !cambiando)
            diferente = false;




        if (pulsado && gameObject.tag == "Boton" && ubicacion && diferente)
        {
            anim.SetBool("BotonPulsado", pulsado);
            cambiando = true;
            cabina.GetComponent<CabinaAscensor>().ActivarAnimacion(true);
            corrigiendoUbicacion = true;
            return;
        }
        else if (pulsado && gameObject.tag == "Boton" && !ubicacion && diferente)
        {
            anim.SetBool("BotonPulsado", pulsado);
            cambiando = true;
            cabina.GetComponent<CabinaAscensor>().ActivarAnimacion(false);
            corrigiendoUbicacion = true;
            return;
        }
        else if (pulsado && gameObject.tag == "Boton" && !ubicacion && !diferente && !corrigiendoUbicacion)
        {
            anim.SetBool("BotonPulsado", pulsado);
            cambiando = true;
            puerta.GetComponent<PuertaAscensor>().ActivarAnimacion(true);
            return;
        }
        else if (pulsado && gameObject.tag == "Boton" && ubicacion && !diferente && !corrigiendoUbicacion)
        {
            anim.SetBool("BotonPulsado", pulsado);
            cambiando = true;
            puerta.GetComponent<PuertaAscensor>().ActivarAnimacion(true);
            return;
        }

        if (pulsado && gameObject.tag == "BotonAscensor" && !cambiando)
        {
            anim.SetBool("BotonPulsado", pulsado);
            cambiando = true;
            cabina.GetComponent<CabinaAscensor>().ActivarAnimacion(!cabina.GetComponent<CabinaAscensor>().Estado);
            return;
        }

    }
}
