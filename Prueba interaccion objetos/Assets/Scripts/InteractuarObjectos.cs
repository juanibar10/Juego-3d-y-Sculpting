using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuarObjectos : MonoBehaviour
{
    public LayerMask layerInteractuable;
    RaycastHit hit;

    public LayerMask layerRecogible;
    public LayerMask layerNota;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerInteractuable))
            {

                if(hit.transform.tag == "Boton" || hit.transform.tag == "BotonAscensor")
                {
                    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                    hit.transform.gameObject.GetComponent<BotonAFalse>().pulsado = true;

                }
                else
                {
                    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                    hit.transform.gameObject.GetComponent<EstadoCubo>().abierto = !hit.transform.gameObject.GetComponent<EstadoCubo>().abierto;
                    hit.transform.gameObject.GetComponent<EstadoCubo>().ActivarAnimacion(hit.transform.gameObject.GetComponent<EstadoCubo>().abierto);
                    Debug.Log("Did Hit");
                }
                
            }
            else
            {
                Debug.Log("Did Not Hit");
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerRecogible))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                hit.transform.gameObject.GetComponent<Pickup>().AddObjeto();
                Debug.Log("Did Hit");
            }
            else
            {
                Debug.Log("Did Not Hit");
            }

            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerNota))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                GameObject.FindGameObjectWithTag("Player").GetComponent<Notas>().ActivarBoton(hit.transform.GetComponent<NotaPrefab>().nota);
                Destroy(hit.transform.gameObject);
                Debug.Log("Did Hit");
            }
            else
            {
                Debug.Log("Did Not Hit");
            }
        }
        
    }
}
        
