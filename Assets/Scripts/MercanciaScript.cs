using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        };
    }
}
