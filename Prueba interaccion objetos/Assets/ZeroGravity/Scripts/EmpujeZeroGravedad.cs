using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpujeZeroGravedad : MonoBehaviour
{
    // Force of individual thrusters
    public float thrusterForce = 10000;
    // Whether or not to add force at position which introduces torque
    public bool addForceAtPosition = false;

    private bool thrusterIsActive = true;
    private Transform objectTransform;
    private Rigidbody objectParentRigidbody;
    private Vector3 _velocity = Vector3.zero;

   

    void FixedUpdate()
    {

        if (thrusterIsActive)
        {
            if (addForceAtPosition)
            {
                objectParentRigidbody.AddForceAtPosition(objectTransform.up * thrusterForce, objectTransform.position);
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
