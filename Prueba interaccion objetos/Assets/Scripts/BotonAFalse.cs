using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonAFalse : MonoBehaviour
{
    public Animator anim;
    public GameObject puerta;
    public GameObject cabina;
    public bool pulsado = false;
    public string ubicacion;
    public bool cambiando;
    
    public void Update()
    {
        anim.SetBool("BotonPulsado", pulsado);



        if (pulsado && gameObject.tag == "BotonAscensor")
        {
            cabina.GetComponent<CabinaAscensor>().ActivarAnimacion(!cabina.GetComponent<CabinaAscensor>().Estado);
        }

        if (pulsado && gameObject.tag == "Boton" && ubicacion == "Abajo" && !cabina.GetComponent<CabinaAscensor>().Estado && !cambiando)
        {
            cambiando = true;
            Debug.Log("entra");
            puerta.GetComponent<PuertaAscensor>().ActivarAnimacion(true);
            return;
        }
        else if(pulsado && gameObject.tag == "Boton" && ubicacion == "Arriba" && cabina.GetComponent<CabinaAscensor>().anim.GetBool("Estado") && !cambiando)
        {
            cambiando = true;
            puerta.GetComponent<PuertaAscensor>().ActivarAnimacion(true);
            return;
        }
        else if (pulsado && ubicacion == "Arriba" && !cabina.GetComponent<CabinaAscensor>().Estado && !cambiando)
        {
            cambiando = true;
            cabina.GetComponent<CabinaAscensor>().ActivarAnimacion(true);
            return;
        }
        else if (pulsado && ubicacion == "Abajo" && cabina.GetComponent<CabinaAscensor>().Estado && !cambiando)
        {
            cambiando = true;
            cabina.GetComponent<CabinaAscensor>().ActivarAnimacion(false);
            return;
        }
    
    }
}
