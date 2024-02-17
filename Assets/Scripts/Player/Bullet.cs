using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Arrow : MonoBehaviour
{
public float bulletDamage = 1;
    void Start()
    {
        StartCoroutine(bulletDestroy());
    }

    IEnumerator bulletDestroy()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.CompareTag("Obsicle"))
       {
        Destroy(gameObject);
       }
       else if(other.CompareTag("Enemy"))
       {
        other.GetComponent<EnemyCombat>().enemyHealth -= bulletDamage;
        Destroy(gameObject);
       }
    }
    
    
}
