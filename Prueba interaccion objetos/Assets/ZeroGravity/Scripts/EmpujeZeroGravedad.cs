using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpujeZeroGravedad : MonoBehaviour
{
    // Force of individual thrusters
    public float thrusterForce = 10000;
    // Whether or not to add force at position which introduces torque
    public bool addForceAtPosition = false;

    private bool thrusterIsActive = false;
    private Transform objectTransform;
    private Rigidbody objectParentRigidbody;
    private Vector3 _velocity = Vector3.zero;

    private void Awake()
    {
        //objectParentRigidbody = GetComponent<Rigidbody>();
        //objectTransform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {

        if (thrusterIsActive)
        {
            if (addForceAtPosition)
            {
                objectParentRigidbody.AddForceAtPosition(objectTransform.up * thrusterForce/100, objectTransform.position);
            }
            else
            {
                objectParentRigidbody.AddRelativeForce(Vector3.forward * thrusterForce);
            }
            _velocity = objectParentRigidbody.velocity;
        }
        else
            objectParentRigidbody.velocity = _velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            thrusterIsActive = true;
    }
}
