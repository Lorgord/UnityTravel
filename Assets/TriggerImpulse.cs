using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerImpulse : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public Vector3 Force;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Launching the barrel!");
    }

    private void OnTriggerStay()
    {
        Rigidbody.AddForce(Force, ForceMode.VelocityChange);

    }
}
