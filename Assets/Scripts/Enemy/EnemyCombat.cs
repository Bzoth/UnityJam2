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
  }
  void Update()
  {
    if (enemyHealth <= 0)
    {
      goldManage.gold++;
      Destroy(gameObject);
    }
  }

  public void TakeEnemyDamage(int damage)
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
