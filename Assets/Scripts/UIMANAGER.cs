using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uiManager : MonoBehaviour
{
    public TextMeshProUGUI TxtMoney;
    public TextMeshProUGUI TxtHealth;

    void Start()
    {
        TxtMoney.text = "";
        TxtHealth.text = "";
    }
    
    public void UpdateMoneyText(int money)
    {
        TxtMoney.text = "$ " + money;
    }

    public void UpdateHealthText(int health)
    {
        TxtHealth.text = "HP " + health;
    }
}
