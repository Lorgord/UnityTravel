using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExplosion : MonoBehaviour
{
    public GameObject explosion;
    public float force = 1.0f;
    public float radius = 5.0f;
    public float upForce = 1.0f;
    private int count;

    public void OnTriggerEnter()
    {
        Debug.Log("The barrel explodes!");

        Vector3 explosionPos = explosion.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        if (count == 0)
        {
            foreach (Collider obj in colliders)
            {
                Rigidbody rb = obj.GetComponent<Rigidbody>();

                if (rb != null)
                    rb.AddExplosionForce(force, explosionPos, radius, upForce, ForceMode.Impulse);
                    count++;
            }
        }
    }
}
