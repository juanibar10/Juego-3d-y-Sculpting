using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaAscensor : MonoBehaviour
{
    public bool abierto = false;
    Animator anim;
    
    

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }



    public void ActivarAnimacion(bool estado)
    {
        anim.SetBool("Estado", estado);
        abierto = estado;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ActivarAnimacion(false);
        }
    }
    
}
