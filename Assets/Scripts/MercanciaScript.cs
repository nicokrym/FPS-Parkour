using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MercanciaScript : MonoBehaviour
{
    public int precio;
    public MoneyManager moneyManager;
    public TextMeshProUGUI TxtCartel;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
        TxtCartel = FindObjectOfType<TextMeshProUGUI>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (moneyManager.updateMoney(-precio))
            {
                TxtCartel.text = gameObject.name;
                Destroy(gameObject);
            }
            else
            {
                TxtCartel.text = "No es posible realizar la transacción, fondos insuficientes.";
            }
        };
    }
}
