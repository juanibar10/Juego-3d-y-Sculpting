using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarOutliner : MonoBehaviour
{

    private void Awake()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }

    private void OnMouseOver()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }
}
