using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MercanciaScript : MonoBehaviour
{
    public int precio;
    public MoneyManager moneyManager;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (moneyManager.updateMoney(-precio))
            {
                Debug.Log(gameObject.name);
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("No es posible realizar la transacción, fondos insuficientes.");
            }
        };
    }
}
