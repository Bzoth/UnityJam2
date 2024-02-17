using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class EnemyCombat : MonoBehaviour
{
  public float enemyMaxHealth = 5;
  public float enemyHealth;
  public EnemyMove enemyMoveComp;
  public GoldManage goldManage;
   [SerializeField] EnemyHealthBar enemyHealthBar;
  

  void Start()
  {
    enemyHealth = enemyMaxHealth;
    enemyMoveComp = GetComponent<EnemyMove>();
    enemyHealthBar = GetComponentInChildren<EnemyHealthBar>();
    enemyHealthBar.UpdateHealth(enemyHealth, enemyMaxHealth);
    goldManage.GetComponent<GoldManage>();
  }


  void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.CompareTag("Bullet") )
        {
          enemyHealthBar.UpdateHealth(enemyHealth, enemyMaxHealth);
          StartCoroutine(enemyDamageSlow());
          if(enemyHealth <= 0)
          {
            Destroy(gameObject);
            goldManage.gold++;
          }
          
        }
    }

  IEnumerator enemyDamageSlow()
  {
    enemyMoveComp.speed -= 1;
    yield return new WaitForSeconds(0.25f);
    enemyMoveComp.speed += 1;
  }
}
