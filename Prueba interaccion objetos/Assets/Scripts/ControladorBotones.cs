using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBotones : MonoBehaviour
{
    public GameObject[] textos;

    public void ActivarTexto1()
    {
        for(int i = 0;i< textos.Length; i++)
        {
            if(i == 0)
                textos[i].SetActive(true);
            else
                textos[i].SetActive(false);
        }
    }
    public void ActivarTexto2()
    {
        for (int i = 0; i < textos.Length; i++)
        {
            if (i == 1)
                textos[i].SetActive(true);
            else
                textos[i].SetActive(false);
        }
    }
    public void ActivarTexto3()
    {
        for (int i = 0; i < textos.Length; i++)
        {
            if (i == 2)
                textos[i].SetActive(true);
            else
                textos[i].SetActive(false);
        }
    }
    public void ActivarTexto4()
    {
        for (int i = 0; i < textos.Length; i++)
        {
            if (i == 3)
                textos[i].SetActive(true);
            else
                textos[i].SetActive(false);
        }
    }
    public void ActivarTexto5()
    {
        for (int i = 4; i < textos.Length; i++)
        {
            if (i == 4)
                textos[i].SetActive(true);
            else
                textos[i].SetActive(false);
        }
    }
    public void ActivarTexto6()
    {
        for (int i = 0; i < textos.Length; i++)
        {
            if (i == 5)
                textos[i].SetActive(true);
            else
                textos[i].SetActive(false);
        }
    }
    public void ActivarTexto7()
    {
        for (int i = 0; i < textos.Length; i++)
        {
            if (i == 6)
                textos[i].SetActive(true);
            else
                textos[i].SetActive(false);
        }
    }
    public void ActivarTexto8()
    {
        for (int i = 0; i < textos.Length; i++)
        {
            if (i == 7)
                textos[i].SetActive(true);
            else
                textos[i].SetActive(false);
        }
    }
    public void ActivarTexto9()
    {
        for (int i = 0; i < textos.Length; i++)
        {
            if (i == 8)
                textos[i].SetActive(true);
            else
                textos[i].SetActive(false);
        }
    }
    public void ActivarTexto10()
    {
        for (int i = 0; i < textos.Length; i++)
        {
            if (i == 9)
                textos[i].SetActive(true);
            else
                textos[i].SetActive(false);
        }
    }
    public void ActivarTexto11()
    {
        for (int i = 0; i < textos.Length; i++)
        {
            if (i == 10)
                textos[i].SetActive(true);
            else
                textos[i].SetActive(false);
        }
    }
}
