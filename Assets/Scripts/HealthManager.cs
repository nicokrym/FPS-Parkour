using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int health;
    public uiManager uiManager;

    void Start()
    {
        uiManager.UpdateHealthText(100);
    }

    public bool UpdateHealth(int points)
    {
        if (health + points < 0)
        {
            return false;
        }
        else
        {
            health += points;
            uiManager.UpdateHealthText(points);
            return true;
        }
    }
}
