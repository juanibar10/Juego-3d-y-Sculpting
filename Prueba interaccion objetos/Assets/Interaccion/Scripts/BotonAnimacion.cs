using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonAnimacion : MonoBehaviour
{
    public void BontonToFalse()
    {
        gameObject.GetComponentInChildren<BotonAFalse>().pulsado = false;
    }
}
