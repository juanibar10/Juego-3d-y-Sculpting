using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AñadirComidaAgua : MonoBehaviour
{



    public void AddComida(int cantidad)
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<ControladorEstadisticas>().comida += cantidad;
        Destroy(gameObject);
    }
    public void AddAgua(int cantidad)
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<ControladorEstadisticas>().agua += cantidad;
        Destroy(gameObject);
    }

}
