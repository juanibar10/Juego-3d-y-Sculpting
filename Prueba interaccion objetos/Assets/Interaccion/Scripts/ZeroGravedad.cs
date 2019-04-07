using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ZeroGravedad : MonoBehaviour
{
    public bool zeroGravedad;

    public Transform camara;
    private Quaternion rotacionCamara;
    private Quaternion rotacionJugador;
    private Vector3 posicion;
    private Quaternion rotacion;

    private ZeroGravityMovement zgm;
    private FirstPersonController fpc;
    private CapsuleCollider collider;
    private CharacterController characterController;
    private Rigidbody rb;
    public float gravedad;
    

    private void Awake()
    {
        zgm = GetComponent<ZeroGravityMovement>();
        fpc = GetComponent<FirstPersonController>();
        collider = GetComponent<CapsuleCollider>();
        characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        gravedad = Physics.gravity.y;
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            zeroGravedad = !zeroGravedad;

        

        if (!zeroGravedad &&( !GameObject.FindGameObjectWithTag("ControladorInventario").GetComponent<ControladorInventario>().abierto && !GameObject.FindGameObjectWithTag("ControladorInventario").GetComponent<ControladorInventario>().abiertoNotas))
        {
            rotacionCamara = camara.rotation;
            rotacionJugador = transform.rotation;

            if (gravedad > -5.5f)
                gravedad -= Time.deltaTime * 3;
            if (gravedad < -5.5f)
                gravedad = -5.5f;

            Physics.gravity = new Vector3(0, gravedad, 0);
            rb.isKinematic = true;
            fpc.enabled = true;
            characterController.enabled = true;
            collider.center = new Vector3(0, 0, 0);
            collider.direction = 1;
            zgm.enabled = false;
            collider.enabled = true;

        }
        if (zeroGravedad && (!GameObject.FindGameObjectWithTag("ControladorInventario").GetComponent<ControladorInventario>().abierto && !GameObject.FindGameObjectWithTag("ControladorInventario").GetComponent<ControladorInventario>().abiertoNotas))
        {
            rotacionCamara = camara.rotation;
            rotacionJugador = transform.rotation;
            if (gravedad < 0)
                gravedad += Time.deltaTime * 3;
            if (gravedad > 0)
                gravedad = 0;

            Physics.gravity = new Vector3(0, gravedad, 0);
            rb.isKinematic = false;
            zgm.enabled = true;
            collider.enabled = true;
            collider.center = new Vector3(0, 0.5f, -0.5f);
            collider.direction = 2;
            fpc.enabled = false;
            characterController.enabled = false;
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Activador")
            zeroGravedad = !zeroGravedad;
    }


}
