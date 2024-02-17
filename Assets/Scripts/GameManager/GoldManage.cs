using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManage : MonoBehaviour
{
    public int gold = 0;
    int speedUpgradeCost = 1;
    int damageUpgradeCost = 1;
    int attackSpeedUpgradeCost = 1;
    int TrapUpgradeCost = 1;
    public EnemyCombat damage;
    public PlayerMovementi playerMovementi;
    public Weapon weapon;

    public void SpeedUpgrader()
    {
        if( gold >= speedUpgradeCost)
        {
            gold -= speedUpgradeCost;
            speedUpgradeCost += 2;
            playerMovementi.speed++;
        }
    }
    public void DamageUpgrader()
    {
        if( gold >= damageUpgradeCost)
        {
            gold -= damageUpgradeCost;
            damageUpgradeCost += 2;
            playerMovementi.speed++;
        }
    }
    public void AttackSpeedUpgrader()
    {
        if( gold >= speedUpgradeCost)
        {
            gold -= speedUpgradeCost;
            speedUpgradeCost += 2;
            playerMovementi.speed++;
        }
    }
    public void TrapUpgrader()
    {
        if( gold >= speedUpgradeCost)
        {
            gold -= speedUpgradeCost;
            speedUpgradeCost += 2;
            playerMovementi.speed++;
        }
    }
}
