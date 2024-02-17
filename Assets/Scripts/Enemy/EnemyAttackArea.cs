using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class EnemyAttackArea : MonoBehaviour
{
    private PlayerHealth playerHealth;
    public EnemyMove enemyMove;
    private bool enemyAttackCD = true;
    private float x;

    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

  void OnTriggerStay2D(Collider2D other)
  {
    if( other.CompareTag("Player") && enemyAttackCD == true)
    {
      StartCoroutine(EnemyAttack());
    }
  }
  IEnumerator EnemyAttack()
  {
    if (enemyAttackCD == true)
    {
    x = enemyMove.speed;
    enemyAttackCD = false;
    enemyMove.speed -= x;
    playerHealth.playerHealth -= 2;
    yield return new WaitForSeconds(2);
    enemyMove.speed += x;
    enemyAttackCD = true;
    }
  }
}
