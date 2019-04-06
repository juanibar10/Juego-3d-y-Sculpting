using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ZeroGravityMovement : MonoBehaviour
{
    public MouseLook mouseLook;
    [HideInInspector]
    public Vector3 m_OriginalCameraPosition;
    [HideInInspector]
    public Camera m_Camera;
    private Vector3 posicion;
    private Rigidbody rb;
    public float velocidad;
    public float turnSpeed = 0.15f;

    public FirstPersonController fpc;
    private CharacterController characterController;

    [HideInInspector]
    public Quaternion rotacion;
    private bool igualarRotacion;
    
    private void Awake()
    {
        m_Camera = Camera.main;
        rb = GetComponent<Rigidbody>();
        posicion = transform.position;
    }

    private void RotateView()
    {
        mouseLook.LookRotation(transform);
    }
    void FixedUpdate()
    {

        RotateView();

        transform.rotation = Camera.main.transform.rotation;
        
        rb.AddRelativeForce (Vector3.forward * velocidad * Input.GetAxis("Vertical"));
        rb.AddRelativeForce(new Vector3(1,0,0) * velocidad * Input.GetAxis("Horizontal"));

        

    }
    
}
