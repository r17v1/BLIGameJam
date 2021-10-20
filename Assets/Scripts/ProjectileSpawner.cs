using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject bullet;
    public float bulletCooldown;
    public GameObject special;
    public float specialCooldown;

    float currentBulletCooldown = 0f, currentSpecialCooldown=0f;

    void Update()
    {
        currentBulletCooldown = Mathf.Max(0f, currentBulletCooldown - Time.deltaTime);
        currentSpecialCooldown = Mathf.Max(0f, currentSpecialCooldown - Time.deltaTime);
    }

    public void shoot()
    {
        if (currentBulletCooldown<=0)
        {
            currentBulletCooldown = bulletCooldown;
            Instantiate(bullet, transform.position, transform.rotation);
            print(currentBulletCooldown);
        }
    }

    public void specialAttack()
    {
        if (currentSpecialCooldown <= 0)
        {
            currentSpecialCooldown = specialCooldown;
            Instantiate(special);
        }
    }

}
