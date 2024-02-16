using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManage : MonoBehaviour
{
    public int gold = 0;
    int upgradeCost = 1;
    public PlayerMovementi playerMovementi;

    public void SpeedUpgrader()
    {
        if( gold >= upgradeCost)
        {
            gold -= upgradeCost;
            upgradeCost += 2;
            playerMovementi.speed++;
        }
    }
}
