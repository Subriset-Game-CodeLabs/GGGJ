using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class PlayVFX : MonoBehaviour
{
    [SerializeField] private GameObject _projectile;
    [SerializeField] private Transform _target;

    private void Fire()
    {
        Vector3 spawnPos = transform.position + (_target.position - transform.position).normalized;
        GameObject p = Instantiate(_projectile, spawnPos, Quaternion.identity);
        var proj = p.GetComponent<Projectile>();
        proj.Target = _target;
    }

    private void Update()
    {
        if(UnityEngine.Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
}
