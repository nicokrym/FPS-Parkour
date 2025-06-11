using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public int money;
    public UIManager uiManager;

    private void Start()
    {
        uiManager.UpdateMoneyText(100);
    }

    public bool updateMoney(int amount)
    {
        if (money + amount < 0)
        {
            return false;
        }
        else
        {
            money += amount;
            uiManager.UpdateMoneyText(money);
            return true;
        }
    }
}
