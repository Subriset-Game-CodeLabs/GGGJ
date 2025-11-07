using System;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Transform _target;

    public WeaponData WeaponData;
    
    // [SerializeField]
    // private float _speed = 8f;
    // [SerializeField]
    // private bool _faceDirection = true;
    // [SerializeField]
    // private GameObject _hitEffect;

    public Transform Target
    {
        get => _target;
        set => _target = value;
    }

    private void Update()
    {
        if (_target.IsUnityNull()) return;
        
        Vector2 dir = (_target.position - transform.position).normalized;
        transform.position += (Vector3)dir * (WeaponData.projectileSpeed * Time.deltaTime);

        if (WeaponData.faceDirection)
        {
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject, 0.5f);
            GameObject hitEffect = Instantiate(WeaponData.projectileHitEffectPrefab, transform);
            Destroy(hitEffect, 1f);
            
        }
    }
    
    
}
