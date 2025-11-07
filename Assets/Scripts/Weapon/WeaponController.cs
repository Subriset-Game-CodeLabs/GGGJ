using System;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private Transform _firePoint;

    [Header("Equipped Weapons")] public List<WeaponData> equippedWeapons = new List<WeaponData>();

    private void Update()
    {
        foreach (var weapon in equippedWeapons)
        {
            weapon.cooldownTimer -= Time.deltaTime;

            if (weapon.cooldownTimer <= 0f)
            {
                FireWeapon(weapon);
                weapon.cooldownTimer = weapon.fireRate;
            }
        }
    }

    private void FireWeapon(WeaponData weapon)
    {
        GameObject proj = Instantiate(weapon.projectilePrefab, _firePoint);
        Projectile projectile = proj.GetComponent<Projectile>();
        projectile.WeaponData = weapon;
        switch (weapon.projectileType)
        {
            case WeaponData.ProjectileType.HOMING:
                projectile.Target = FindNearestTarget();
                break;
        }
    }

    Transform FindNearestTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float minDist = Mathf.Infinity;
        Transform nearest = null;

        foreach (GameObject e in enemies)
        {
            float dist = Vector2.Distance(transform.position, e.transform.position);
            if (dist < minDist)
            {
                minDist = dist;
                nearest = e.transform;
            }
        }

        return nearest;
    }
}