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

    private void Awake()
    {
        zgm = GetComponent<ZeroGravityMovement>();
        fpc = GetComponent<FirstPersonController>();
        collider = GetComponent<CapsuleCollider>();
        characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            zeroGravedad = !zeroGravedad;
        }

        if (!zeroGravedad)
        {
            rotacionCamara = camara.rotation;
            rotacionJugador = transform.rotation;
            rb.useGravity = true;
            rb.isKinematic = true;
            fpc.enabled = true;
            characterController.enabled = true;

            zgm.enabled = false;
            collider.enabled = false;
            
            

        }
        else
        {
            rotacionCamara = camara.rotation;
            rotacionJugador = transform.rotation;
            rb.useGravity = false;
            rb.isKinematic = false;
            zgm.enabled = true;
            collider.enabled = true;
            fpc.enabled = false;
            characterController.enabled = false;
        }
        

    }

   
}
