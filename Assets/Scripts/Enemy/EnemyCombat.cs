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
  public float damage = 1f;
  [SerializeField] EnemyHealthBar enemyHealthBar;

  void Start()
  {
    enemyHealth = enemyMaxHealth;
    enemyMoveComp = GetComponent<EnemyMove>();
    enemyHealthBar = GetComponentInChildren<EnemyHealthBar>();
    enemyHealthBar.UpdateHealth(enemyHealth, enemyMaxHealth);
    goldManage.GetComponent<GoldManage>();
  }
  void Update()
  {
    if (enemyHealth <= 0)
    {
      goldManage.gold++;
      Destroy(gameObject);
    }
  }

  void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.CompareTag("Bullet") )
        {
          
          if(enemyHealth > 0)
          {
            TakeEnemyDamage();
          }
          else
          {
            Destroy(gameObject);
          }
          
        }
    }

  void TakeEnemyDamage()
  {

    enemyHealth -= damage;
    enemyHealthBar.UpdateHealth(enemyHealth, enemyMaxHealth);
    StartCoroutine(enemyDamageSlow());
  }
  IEnumerator enemyDamageSlow()
  {
    enemyMoveComp.speed -= 1;
    yield return new WaitForSeconds(0.5f);
    enemyMoveComp.speed += 1;
  }
}
