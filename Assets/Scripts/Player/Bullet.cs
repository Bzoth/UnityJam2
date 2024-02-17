using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
public Weapon weapon;
    void Start()
    {
        StartCoroutine(bulletDestroy());
        weapon = GameObject.FindGameObjectWithTag("Weapon").GetComponent<Weapon>();
    }

    IEnumerator bulletDestroy()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.CompareTag("Enemy"))
       {
        other.GetComponent<EnemyCombat>().enemyHealth -= weapon.bulletDamage;
        Destroy(gameObject);
       }
       else if(other.CompareTag("Obsicle"))
       {
        Destroy(gameObject);
       }
    }
    
    
}
