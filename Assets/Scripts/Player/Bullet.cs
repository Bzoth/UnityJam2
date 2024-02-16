using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(bulletDestroy());
    }

    IEnumerator bulletDestroy()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.CompareTag("Animal") )
        {
            other.gameObject.GetComponent<EnemyCombat>().TakeEnemyDamage(1);
            Destroy(gameObject);
        }
    }
    
}
