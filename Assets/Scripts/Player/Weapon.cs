using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 8;
    private bool canFire = true;

    public void Fire()
    {
        StartCoroutine(FireCooldown());
    }

    IEnumerator FireCooldown()
    {
        if(canFire == true)
        {
            canFire = false;
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
            yield return new WaitForSeconds(0.4f);
            canFire = true;
        }
    }
}
