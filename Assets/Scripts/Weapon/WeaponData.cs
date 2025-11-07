using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Weapons/WeaponData")] 
public class WeaponData : GGJData
{
    [Header("Stats")]
    public string weaponName;
    public float fireRate ;
    public int damage;
    public float projectileSpeed;
    public float cooldownTimer;

    [Header("Projectile Settings")]
    public GameObject projectilePrefab;
    public GameObject projectileHitEffectPrefab;
    public ProjectileType projectileType;
    public bool faceDirection;
    
    
    public enum ProjectileType
    {
        HOMING,
    }
}
