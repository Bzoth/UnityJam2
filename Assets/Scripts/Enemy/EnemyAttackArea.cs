using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class EnemyAttackArea : MonoBehaviour
{
    private PlayerHealth playerHealth;

    public bool enemyAnimCheck;
    public EnemyMove enemyMove;
    private bool enemyAttackCD = true;
    private float x;
    private Animator anim;

    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
      AnimControl();
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
      enemyAnimCheck = true;
      
      x = enemyMove.speed;
      enemyAttackCD = false;
      enemyMove.speed -= x;
      playerHealth.playerHealth -= 2;
      yield return new WaitForSeconds(1);
      enemyAnimCheck = false;
      enemyMove.speed += x;
      enemyAttackCD = true;
    }
  }

  private void AnimControl()
  {
    
  }
}
