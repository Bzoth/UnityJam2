using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManage : MonoBehaviour
{
    public float gold = 0;
    float speedUpgradeCost = 1;
    float damageUpgradeCost = 1;
    float attackSpeedUpgradeCost = 1;
    float HealthUpgradeCost = 1;
    public PlayerMovementi playerMovementi;
    public Weapon weapon;
    public PlayerHealth playerHealth;
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
            weapon.bulletDamage++;
        }
    }
    public void AttackSpeedUpgrader()
    {
        if( gold >= attackSpeedUpgradeCost)
        {
            gold -= attackSpeedUpgradeCost;
            attackSpeedUpgradeCost += 2;
            weapon.attackSpeed -= 0.3f;
        }
    }
    public void HealthUpgrader()
    {
        if( gold >= HealthUpgradeCost)
        {
            gold -= HealthUpgradeCost;
            HealthUpgradeCost += 2;
            playerHealth.playerHealth += 5;
            playerHealth.playerMaxhealth += 5;
        }
    }
    
}
