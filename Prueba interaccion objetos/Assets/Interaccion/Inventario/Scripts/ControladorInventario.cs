using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ControladorInventario : MonoBehaviour
{
    public GameObject inventario;
    public GameObject notas;
    private bool abierto = false;
    private bool abiertoNotas = false;

   

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !abiertoNotas)
        {
            abierto = !abierto;
            GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().enabled = !abierto;
        }

        GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().m_MouseLook.SetCursorLock(!abierto);
        inventario.SetActive(abierto);

        if (Input.GetKeyDown(KeyCode.O) && !abierto)
        {
            abiertoNotas = !abiertoNotas;
            GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().enabled = !abiertoNotas;
        }
        GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().m_MouseLook.SetCursorLock(!abiertoNotas);
        notas.SetActive(abiertoNotas);
    }

    public void CerrarInventario()
    {
        abierto = !abierto;
        GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().m_MouseLook.SetCursorLock(true);
        GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().enabled = !abierto;
    }

    public void CerrarNotas()
    {
        abiertoNotas = !abiertoNotas;
        GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().m_MouseLook.SetCursorLock(true);
        GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().enabled = !abiertoNotas;
    }

    public void botonNotas()
    {
        abiertoNotas = !abiertoNotas;
        abierto = !abierto;
    }

    public void botonInventario()
    {
        abierto = !abierto;
        abiertoNotas = !abiertoNotas;
    }


}
