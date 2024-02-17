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
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
       if(!other.CompareTag("Player"))
       {
        Destroy(gameObject);
       }
    }
    
}
