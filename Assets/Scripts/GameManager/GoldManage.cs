using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI costTextZero;
    public TextMeshProUGUI costTextOne;
    public TextMeshProUGUI costTextTwo;
    public TextMeshProUGUI costTextThree;

    public Sprite tier1,tier2,tier3,tier4,tier5,tier6;
    public Image speedTier,damageTier,attackSpeedTier,healthTier;

    void Update()
    {
        GoldTextChange();
        TierChanger();
    }
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

    public void GoldTextChange()
    {
       goldText.text = gold.ToString();
       costTextZero.text = speedUpgradeCost.ToString();
       costTextOne.text = damageUpgradeCost.ToString();
       costTextTwo.text = attackSpeedUpgradeCost.ToString();
       costTextThree.text = HealthUpgradeCost.ToString();
    }

    public void TierChanger()
    {
        if(speedUpgradeCost == 3)
        {
            speedTier.sprite = tier2;
        }
        else if(speedUpgradeCost == 5)
        {
            speedTier.sprite = tier3;
        }
        else if(speedUpgradeCost == 7)
        {
            speedTier.sprite = tier4;
        }
        else if(speedUpgradeCost == 9)
        {
            speedTier.sprite = tier5;
        }
        else if(speedUpgradeCost == 11)
        {
            speedTier.sprite = tier6;
        }

        if(damageUpgradeCost == 3)
        {
            damageTier.sprite = tier2;
        }
        else if(damageUpgradeCost == 5)
        {
            damageTier.sprite = tier3;
        }
        else if(damageUpgradeCost == 7)
        {
            damageTier.sprite = tier4;
        }
        else if(damageUpgradeCost == 9)
        {
            damageTier.sprite = tier5;
        }
        else if(damageUpgradeCost == 11)
        {
            damageTier.sprite = tier6;
        }

        if(attackSpeedUpgradeCost == 3)
        {
            attackSpeedTier.sprite = tier2;
        }
        else if(attackSpeedUpgradeCost == 5)
        {
            attackSpeedTier.sprite = tier3;
        }
        else if(attackSpeedUpgradeCost == 7)
        {
            attackSpeedTier.sprite = tier4;
        }
        else if(attackSpeedUpgradeCost == 9)
        {
            attackSpeedTier.sprite = tier5;
        }
        else if(attackSpeedUpgradeCost == 11)
        {
            attackSpeedTier.sprite = tier6;
        }

        if(HealthUpgradeCost == 3)
        {
            healthTier.sprite = tier2;
        }
        else if(HealthUpgradeCost == 5)
        {
            healthTier.sprite = tier3;
        }
        else if(HealthUpgradeCost == 7)
        {
            healthTier.sprite = tier4;
        }
        else if(HealthUpgradeCost == 9)
        {
            healthTier.sprite = tier5;
        }
        else if(HealthUpgradeCost == 11)
        {
            healthTier.sprite = tier6;
        }
    }
    
}
