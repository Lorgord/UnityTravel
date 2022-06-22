using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;
    void OnCollisionEnter()
    {
        //Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);

    }
}
