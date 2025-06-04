using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public float money;

    public bool updateMoney(float amount)
    {
        if (money + amount < 0)
        {
            return false;
        }
        else
        {
            money += amount;
            return true;
        }
    }
}
